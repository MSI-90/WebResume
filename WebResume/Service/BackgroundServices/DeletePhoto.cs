
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Service.Contracts;

namespace Service.BackgroundServices
{
  public sealed class DeletePhoto(ILogger<DeletePhoto> logger, IServiceScopeFactory factory) : IHostedService, IAsyncDisposable
  {
    private readonly Task _completedTask = Task.CompletedTask;
    private int _executionCount = 0;
    private Timer? _timer;
    
    public Task StartAsync(CancellationToken cancellationToken)
    {
      logger.LogInformation($"Сервис {nameof(DeletePhoto)} запущен.");
      _timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromMinutes(2));
      return Task.CompletedTask;
    }

    private async void DoWork(object? state)
    {
      int count = Interlocked.Increment(ref _executionCount);
      var factoryScope = factory.CreateScope();
      var bufferInfo = factoryScope.ServiceProvider.GetRequiredService<IBufferInfo>();
      await bufferInfo.DeletePhotoInfoFromBuffer();
      logger.LogInformation($"{nameof(DeletePhoto)} работает, число запусков: {count}");
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
      logger.LogInformation($"{nameof(DeletePhoto)} остановлен.");
      _timer?.Change(Timeout.Infinite, 0);
      return _completedTask;
    }

    public async ValueTask DisposeAsync()
    {
      if (_timer is IAsyncDisposable timer)
      {
        await timer.DisposeAsync();
      }
      _timer = null;
    }
  }
}

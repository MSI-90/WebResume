
using Contracts;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Service.Contracts;

namespace Service.BackgroundServices
{
  public sealed class DeletePhoto(ILoggerManager loggerManager, IServiceProvider provider) : IHostedService, IAsyncDisposable
  {
    private readonly Task _completedTask = Task.CompletedTask;
    private int _executionCount = 0;
    private Timer? _timer;
    
    public Task StartAsync(CancellationToken cancellationToken)
    {
      loggerManager.LogInfo($"Сервис {nameof(DeletePhoto)} запущен.");
      _timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromSeconds(5));
      return Task.CompletedTask;
    }

    private void DoWork(object? state)
    {
      int count = Interlocked.Increment(ref _executionCount);
      loggerManager.LogInfo($"{nameof(DeletePhoto)} работает, число запусков: {count}");
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
      loggerManager.LogInfo($"{nameof(DeletePhoto)} остановлен.");
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

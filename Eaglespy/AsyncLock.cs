using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

// Token: 0x02000031 RID: 49
public class AsyncLock
{
	// Token: 0x060001D2 RID: 466 RVA: 0x000023B0 File Offset: 0x000005B0
	public AsyncLock()
	{
		this.m_semaphore = new SemaphoreSlim(1, 1);
	}

	// Token: 0x060001D3 RID: 467 RVA: 0x00013874 File Offset: 0x00011A74
	[DebuggerStepThrough]
	public Task<IDisposable> LockAsync()
	{
		AsyncLock.VB_0024StateMachine_2_LockAsync vb_0024StateMachine_2_LockAsync = new AsyncLock.VB_0024StateMachine_2_LockAsync();
		vb_0024StateMachine_2_LockAsync._0024VB_0024Me = this;
		vb_0024StateMachine_2_LockAsync._0024State = -1;
		vb_0024StateMachine_2_LockAsync._0024Builder = AsyncTaskMethodBuilder<IDisposable>.Create();
		vb_0024StateMachine_2_LockAsync._0024Builder.Start<AsyncLock.VB_0024StateMachine_2_LockAsync>(ref vb_0024StateMachine_2_LockAsync);
		return vb_0024StateMachine_2_LockAsync._0024Builder.Task;
	}

	// Token: 0x060001D4 RID: 468 RVA: 0x000023C5 File Offset: 0x000005C5
	public void Release()
	{
		this.m_semaphore.Release();
	}

	// Token: 0x04000145 RID: 325
	private SemaphoreSlim m_semaphore;

	// Token: 0x02000032 RID: 50
	private class Releaser : IDisposable
	{
		// Token: 0x060001D5 RID: 469 RVA: 0x000023D3 File Offset: 0x000005D3
		public Releaser(AsyncLock @lock)
		{
			this.m_lock = @lock;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x000138BC File Offset: 0x00011ABC
		public void Dispose()
		{
			if (this.m_lock != null)
			{
				this.m_lock.Release();
				this.m_lock = null;
			}
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x000023E2 File Offset: 0x000005E2
		void IDisposable.Dispose()
		{
			this.Dispose();
		}

		// Token: 0x04000146 RID: 326
		private AsyncLock m_lock;
	}
}

using System;
using System.Threading;
using System.Threading.Tasks;

namespace RethinkDb.Driver.ReGrid
{
    /// <summary>
    /// A ReGrid download stream.
    /// </summary>
    public abstract partial class DownloadStream : BaseStream
    {
        /// <summary>
        /// The underlying bucket container for <see cref="FileInfo"/>
        /// </summary>
        protected readonly Bucket bucket;

        /// <summary>
        /// Constructs a new download stream
        /// </summary>
        /// <param name="bucket">The bucket the <paramref name="fileInfo"/> belongs to.</param>
        /// <param name="fileInfo"><see cref="FileInfo"/></param>
        protected DownloadStream(Bucket bucket, FileInfo fileInfo) : base(fileInfo)
        {
            this.bucket = bucket;
        }

        private bool disposed;

        /// <summary>
        /// True, download streams are readable.
        /// </summary>
        public override bool CanRead => true;

        /// <summary>
        /// False, download streams cannot be written to.
        /// </summary>
        public override bool CanWrite => false;

        /// <summary>
        /// The total length of the stored file.
        /// </summary>
        public override long Length => FileInfo.Length;


        /// <summary>
        /// Not supported
        /// </summary>
        public override void Flush()
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Not supported
        /// </summary>
        public override Task FlushAsync(CancellationToken cancellationToken)
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Not supported
        /// </summary>
        public override void SetLength(long value)
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Not supported
        /// </summary>
        public override void Write(byte[] buffer, int offset, int count)
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Not supported
        /// </summary>
        public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Disposes the stream
        /// </summary>
        /// <param name="disposing"></param>
        // protected methods
        protected override void Dispose(bool disposing)
        {
            if( !disposed )
            {
                disposed = true;
            }

            base.Dispose(disposing);
        }

        /// <summary>
        /// Trows if disposed.
        /// </summary>
        protected virtual void ThrowIfDisposed()
        {
            if( disposed )
            {
                throw new ObjectDisposedException(GetType().Name);
            }
        }
    }
}
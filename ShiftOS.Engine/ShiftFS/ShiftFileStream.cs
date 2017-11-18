using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace ShiftOS.Engine.ShiftFS
{
	/// <summary>
	/// To be implemented
	/// </summary>
	class ShiftFileStream : Stream
	{
		public ShiftFileStream() => throw new NotImplementedException();

		/// <inheritdoc />
		public override void Flush() => throw new NotImplementedException();

		/// <inheritdoc />
		public override long Seek(long offset, SeekOrigin origin) => throw new NotImplementedException();

		/// <inheritdoc />
		public override void SetLength(long value) => throw new NotImplementedException();

		/// <inheritdoc />
		public override int Read(byte[] buffer, int offset, int count) => throw new NotImplementedException();

		/// <inheritdoc />
		public override void Write(byte[] buffer, int offset, int count) => throw new NotImplementedException();

		/// <inheritdoc />
		public override bool CanRead { get; }

		/// <inheritdoc />
		public override bool CanSeek { get; }

		/// <inheritdoc />
		public override bool CanWrite { get; }

		/// <inheritdoc />
		public override long Length { get; }

		/// <inheritdoc />
		public override long Position { get; set; }
	}
}

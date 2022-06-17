using System;
using Deedle;

namespace DeedleBuildIssue
{
    public class FrameBuilder
	{
		public FrameBuilder()
		{
		}

		// If I uncomment this method, the build hangs.
		public Frame<DateTimeOffset, string> ToFrame()
		{
			return Frame.CreateEmpty<DateTimeOffset, string>();
		}
	}
}
﻿// ReSharper disable UnusedAutoPropertyAccessor.Global

using LibMpv.Api;

namespace LibMpv;

public class MpvPropertyEventArgs : EventArgs
{
    public MpvPropertyEventArgs(MpvFormat format, string name, object? value, ulong replyData, int errorCode = 0)
    {
        Format = format;
        Name = name;
        Value = value;
        ReplyData = replyData;
        ErrorCode = errorCode;
    }

    public MpvFormat Format { get; }
    public string Name { get; }
    public object? Value { get; }
    public ulong ReplyData { get; }
    public int ErrorCode { get; }
}

public class MpvReplyEventArgs: EventArgs
{
    public MpvReplyEventArgs(ulong replyData, int errorCode)
    {
        ReplyData = replyData;
        ErrorCode = errorCode;
    }

    public ulong ReplyData { get; }
    public int ErrorCode { get; }
}

public class MpvLogMessageEventArgs : EventArgs
{
    public MpvLogMessageEventArgs(string prefix, string level, string text, MpvLogLevel logLevel)
    {
        Prefix = prefix;
        Level = level;
        Text = text;
        LogLevel = logLevel;
    }

    public string Prefix { get; }
    public string Level { get; }
    public string Text { get; }
    public MpvLogLevel LogLevel { get; }
}

public class MpvEndFileEventArgs : EventArgs
{
    public MpvEndFileEventArgs(MpvEndFileReason reason, int error, long playListEntryId)
    {
        Reason = reason;
        Error = error;
        PlayListEntryId = playListEntryId;
    }

    public MpvEndFileReason Reason { get; }
    public int Error { get; }
    public long PlayListEntryId { get; }
}

public class MpvStartFileEventArgs : EventArgs
{
    public MpvStartFileEventArgs(long playListEntryId)
    {
        PlayListEntryId = playListEntryId;
    }
    public long PlayListEntryId { get; }
}
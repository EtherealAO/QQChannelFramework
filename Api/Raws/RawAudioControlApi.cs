﻿using QQChannelFramework.Api.Types;

namespace QQChannelFramework.Api.Raws;

/// <summary>
/// 源Api信息 - 音频控制
/// </summary>
public struct RawAudioControlApi: Base.IRawApiInfo
{
    public string Version => "1.0";
    public string Url => "/channels/{channel_id}/audio";
    public MethodType Method => MethodType.POST;
}

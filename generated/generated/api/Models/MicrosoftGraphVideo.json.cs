namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>video</summary>
    public partial class MicrosoftGraphVideo
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        partial void AfterFromJson(Sample.API.Runtime.Json.JsonObject json);
        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Sample.API.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        partial void AfterToJson(ref Sample.API.Runtime.Json.JsonObject container);
        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>
        partial void BeforeFromJson(Sample.API.Runtime.Json.JsonObject json, ref bool returnNow);
        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>
        partial void BeforeToJson(ref Sample.API.Runtime.Json.JsonObject container, ref bool returnNow);
        /// <summary>
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IMicrosoftGraphVideo.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Sample.API.Models.IMicrosoftGraphVideo.</returns>
        public static Sample.API.Models.IMicrosoftGraphVideo FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new MicrosoftGraphVideo(json) : null;
        }
        /// <summary>
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="MicrosoftGraphVideo" />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal MicrosoftGraphVideo(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_audioBitsPerSample = If( json?.PropertyT<Sample.API.Runtime.Json.JsonNumber>("audioBitsPerSample"), out var __jsonAudioBitsPerSample) ? (int?)__jsonAudioBitsPerSample : AudioBitsPerSample;}
            {_audioChannels = If( json?.PropertyT<Sample.API.Runtime.Json.JsonNumber>("audioChannels"), out var __jsonAudioChannels) ? (int?)__jsonAudioChannels : AudioChannels;}
            {_audioFormat = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("audioFormat"), out var __jsonAudioFormat) ? (string)__jsonAudioFormat : (string)AudioFormat;}
            {_audioSamplesPerSecond = If( json?.PropertyT<Sample.API.Runtime.Json.JsonNumber>("audioSamplesPerSecond"), out var __jsonAudioSamplesPerSecond) ? (int?)__jsonAudioSamplesPerSecond : AudioSamplesPerSecond;}
            {_bitrate = If( json?.PropertyT<Sample.API.Runtime.Json.JsonNumber>("bitrate"), out var __jsonBitrate) ? (int?)__jsonBitrate : Bitrate;}
            {_duration = If( json?.PropertyT<Sample.API.Runtime.Json.JsonNumber>("duration"), out var __jsonDuration) ? (long?)__jsonDuration : Duration;}
            {_fourCC = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("fourCC"), out var __jsonFourCC) ? (string)__jsonFourCC : (string)FourCC;}
            {_frameRate = If( json?.PropertyT<Sample.API.Runtime.Json.JsonNumber>("frameRate"), out var __jsonFrameRate) ? (double?)__jsonFrameRate : FrameRate;}
            {_height = If( json?.PropertyT<Sample.API.Runtime.Json.JsonNumber>("height"), out var __jsonHeight) ? (int?)__jsonHeight : Height;}
            {_width = If( json?.PropertyT<Sample.API.Runtime.Json.JsonNumber>("width"), out var __jsonWidth) ? (int?)__jsonWidth : Width;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Serializes this instance of <see cref="MicrosoftGraphVideo" /> into a <see cref="Sample.API.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="MicrosoftGraphVideo" /> as a <see cref="Sample.API.Runtime.Json.JsonNode" />.
        /// </returns>
        public Sample.API.Runtime.Json.JsonNode ToJson(Sample.API.Runtime.Json.JsonObject container, Sample.API.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Sample.API.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != AudioBitsPerSample ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonNumber((int)AudioBitsPerSample) : null, "audioBitsPerSample" ,container.Add );
            AddIf( null != AudioChannels ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonNumber((int)AudioChannels) : null, "audioChannels" ,container.Add );
            AddIf( null != (((object)AudioFormat)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(AudioFormat.ToString()) : null, "audioFormat" ,container.Add );
            AddIf( null != AudioSamplesPerSecond ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonNumber((int)AudioSamplesPerSecond) : null, "audioSamplesPerSecond" ,container.Add );
            AddIf( null != Bitrate ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonNumber((int)Bitrate) : null, "bitrate" ,container.Add );
            AddIf( null != Duration ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonNumber((long)Duration) : null, "duration" ,container.Add );
            AddIf( null != (((object)FourCC)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(FourCC.ToString()) : null, "fourCC" ,container.Add );
            AddIf( null != FrameRate ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonNumber((double)FrameRate) : null, "frameRate" ,container.Add );
            AddIf( null != Height ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonNumber((int)Height) : null, "height" ,container.Add );
            AddIf( null != Width ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonNumber((int)Width) : null, "width" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}
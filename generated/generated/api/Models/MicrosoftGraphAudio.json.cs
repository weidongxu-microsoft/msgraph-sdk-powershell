namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>audio</summary>
    public partial class MicrosoftGraphAudio
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
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IMicrosoftGraphAudio.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Sample.API.Models.IMicrosoftGraphAudio.</returns>
        public static Sample.API.Models.IMicrosoftGraphAudio FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new MicrosoftGraphAudio(json) : null;
        }
        /// <summary>
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="MicrosoftGraphAudio" />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal MicrosoftGraphAudio(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_album = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("album"), out var __jsonAlbum) ? (string)__jsonAlbum : (string)Album;}
            {_albumArtist = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("albumArtist"), out var __jsonAlbumArtist) ? (string)__jsonAlbumArtist : (string)AlbumArtist;}
            {_artist = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("artist"), out var __jsonArtist) ? (string)__jsonArtist : (string)Artist;}
            {_bitrate = If( json?.PropertyT<Sample.API.Runtime.Json.JsonNumber>("bitrate"), out var __jsonBitrate) ? (long?)__jsonBitrate : Bitrate;}
            {_composers = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("composers"), out var __jsonComposers) ? (string)__jsonComposers : (string)Composers;}
            {_copyright = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("copyright"), out var __jsonCopyright) ? (string)__jsonCopyright : (string)Copyright;}
            {_disc = If( json?.PropertyT<Sample.API.Runtime.Json.JsonNumber>("disc"), out var __jsonDisc) ? (int?)__jsonDisc : Disc;}
            {_discCount = If( json?.PropertyT<Sample.API.Runtime.Json.JsonNumber>("discCount"), out var __jsonDiscCount) ? (int?)__jsonDiscCount : DiscCount;}
            {_duration = If( json?.PropertyT<Sample.API.Runtime.Json.JsonNumber>("duration"), out var __jsonDuration) ? (long?)__jsonDuration : Duration;}
            {_genre = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("genre"), out var __jsonGenre) ? (string)__jsonGenre : (string)Genre;}
            {_hasDrm = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("hasDrm"), out var __jsonHasDrm) ? (bool?)__jsonHasDrm : HasDrm;}
            {_isVariableBitrate = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("isVariableBitrate"), out var __jsonIsVariableBitrate) ? (bool?)__jsonIsVariableBitrate : IsVariableBitrate;}
            {_title = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("title"), out var __jsonTitle) ? (string)__jsonTitle : (string)Title;}
            {_track = If( json?.PropertyT<Sample.API.Runtime.Json.JsonNumber>("track"), out var __jsonTrack) ? (int?)__jsonTrack : Track;}
            {_trackCount = If( json?.PropertyT<Sample.API.Runtime.Json.JsonNumber>("trackCount"), out var __jsonTrackCount) ? (int?)__jsonTrackCount : TrackCount;}
            {_year = If( json?.PropertyT<Sample.API.Runtime.Json.JsonNumber>("year"), out var __jsonYear) ? (int?)__jsonYear : Year;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Serializes this instance of <see cref="MicrosoftGraphAudio" /> into a <see cref="Sample.API.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="MicrosoftGraphAudio" /> as a <see cref="Sample.API.Runtime.Json.JsonNode" />.
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
            AddIf( null != (((object)Album)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Album.ToString()) : null, "album" ,container.Add );
            AddIf( null != (((object)AlbumArtist)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(AlbumArtist.ToString()) : null, "albumArtist" ,container.Add );
            AddIf( null != (((object)Artist)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Artist.ToString()) : null, "artist" ,container.Add );
            AddIf( null != Bitrate ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonNumber((long)Bitrate) : null, "bitrate" ,container.Add );
            AddIf( null != (((object)Composers)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Composers.ToString()) : null, "composers" ,container.Add );
            AddIf( null != (((object)Copyright)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Copyright.ToString()) : null, "copyright" ,container.Add );
            AddIf( null != Disc ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonNumber((int)Disc) : null, "disc" ,container.Add );
            AddIf( null != DiscCount ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonNumber((int)DiscCount) : null, "discCount" ,container.Add );
            AddIf( null != Duration ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonNumber((long)Duration) : null, "duration" ,container.Add );
            AddIf( null != (((object)Genre)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Genre.ToString()) : null, "genre" ,container.Add );
            AddIf( null != HasDrm ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)HasDrm) : null, "hasDrm" ,container.Add );
            AddIf( null != IsVariableBitrate ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)IsVariableBitrate) : null, "isVariableBitrate" ,container.Add );
            AddIf( null != (((object)Title)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Title.ToString()) : null, "title" ,container.Add );
            AddIf( null != Track ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonNumber((int)Track) : null, "track" ,container.Add );
            AddIf( null != TrackCount ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonNumber((int)TrackCount) : null, "trackCount" ,container.Add );
            AddIf( null != Year ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonNumber((int)Year) : null, "year" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}
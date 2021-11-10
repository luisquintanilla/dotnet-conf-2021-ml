/*
 * Copyright 2018 Manufaktura Programów Jacek Salamon http://musicengravingcontrols.com/
 * MIT LICENCE

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"),
to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense,
and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using Manufaktura.Controls.Model.Assertions;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Model.SMuFL;
using Manufaktura.Controls.Rendering;
using Manufaktura.Controls.SMuFL.EagerLoading;
using Manufaktura.Controls.SMuFL.LazyLoadingWithStaticProxy;
using Manufaktura.Controls.SMuFL.Utilities;
using Manufaktura.Core.Serialization;
using Newtonsoft.Json;
using Polenter.Serialization;
using System;
using System.IO;
using System.Reflection;

namespace Manufaktura.Controls.SMuFL
{
    public class SMuFLMusicFont : IMusicFont
    {
        private readonly ISMuFLGlyphs glyphsInstance;
        private readonly TimeSignatureNumberUtility timeSignatureNumberUtility;
        private readonly TupletNumberUtility tupletNumberUtility;

        public SMuFLMusicFont(ISMuFLGlyphs glyphsInstance)
        {
            this.glyphsInstance = glyphsInstance;
            timeSignatureNumberUtility = new TimeSignatureNumberUtility(glyphsInstance);
            tupletNumberUtility = new TupletNumberUtility(glyphsInstance);
        }

        public char AugmentationDot => '\uE1E7';

        public char BraceLeft => '\uE000';

        public char BraceRight => '\uE001';

        public char Bracket => '\uE002';

        public char CClef => '\uE05C';

        public char CClef15ma => CClef;

        public char CClef15mb => CClef;

        public char CClef8va => CClef;

        public char CClef8vb => '\uE05D';

        public char CommonTime => '\uE08A';

        public char CutTime => '\uE08B';

        public char DoubleFlat => '\uE264';

        public char DoubleSharp => '\uE263';

        public char FClef => '\uE062';

        public char FClef15ma => '\uE066';

        public char FClef15mb => '\uE063';

        public char FClef8va => '\uE065';

        public char FClef8vb => '\uE064';

        public char FermataDown => '\uE4C1';

        public char FermataUp => '\uE4C0';

        public char Flat => '\uE260';

        public char GClef => '\uE050';

        public char GClef15ma => '\uE054';

        public char GClef15mb => '\uE051';

        public char GClef8va => '\uE053';

        public char GClef8vb => '\uE052';

        public bool IsSMuFLFont => true;

        public char Mordent => glyphsInstance.OrnamentMordent.Character;

        public char MordentInverted => glyphsInstance.OrnamentMordentInverted.Character;

        public char MordentShort => '\uE56C';

        public char Natural => '\uE261';

        public char NoteDoubleWhole => '\uE0A0';

        public char NoteDoubleWholeCue => glyphsInstance.NoteDoubleWhole.Character;

        public char NoteDoubleWholeLarge => glyphsInstance.NoteDoubleWhole.Character;

        public char NoteEighth => throw new NotImplementedException();

        public char NoteFlag128th => '\uE248';

        public char NoteFlag128thRev => '\uE249';

        public char NoteFlag32nd => '\uE244';

        public char NoteFlag32ndRev => '\uE245';

        public char NoteFlag64th => '\uE246';

        public char NoteFlag64thRev => '\uE247';

        public char NoteFlagEighth => '\uE240';

        public char NoteFlagEighthRev => '\uE241';

        public char NoteFlagSixteenth => '\uE242';

        public char NoteFlagSixteenthRev => '\uE243';

        public char NoteHalf => '\uE0A3';

        public char NoteheadBlack => glyphsInstance.NoteheadBlack.Character;

        public char NoteheadBlackCue => glyphsInstance.NoteheadBlack.Character;

        public char NoteheadBlackLarge => glyphsInstance.NoteheadBlack.Character;

        public char NoteheadHalf => '\uE0A3';

        public char NoteheadHalfCue => glyphsInstance.NoteheadHalf.Character;

        public char NoteheadHalfLarge => glyphsInstance.NoteheadHalf.Character;

        public char NoteQuarter => '\uE0A4';

        public char NoteSixteenth => glyphsInstance.Note16ThUp.Character;

        public char NoteWhole => '\uE0A2';

        public char NoteWholeCue => glyphsInstance.NoteWhole.Character;

        public char NoteWholeLarge => glyphsInstance.NoteWhole.Character;

        public char PercussionClef => '\uE069';

        public char RepeatBackward => '\uE041';

        public char RepeatForward => '\uE040';

        public char Rest32nd => '\uE4E8';

        public char RestEighth => '\uE4E6';

        public char RestHalf => '\uE4E4';

        public char RestMultimeasure => glyphsInstance.RestHBar.Character;

        public char RestQuarter => '\uE4E5';

        public char RestSixteenth => '\uE4E7';

        public char RestWhole => '\uE4E3';

        public char Sharp => '\uE262';

        public char SquareBracketLeft => glyphsInstance.Bracket.Character;

        public char Staff4Lines => throw new NotImplementedException();

        public char Staff5Lines => throw new NotImplementedException();

        public char Time0 => '\uE080';

        public char Time1 => '\uE081';

        public char Time2 => '\uE082';

        public char Time3 => '\uE083';

        public char Time4 => '\uE084';

        public char Time5 => '\uE085';

        public char Time6 => '\uE086';

        public char Time7 => '\uE087';

        public char Time8 => '\uE088';

        public char Time9 => '\uE089';

        public char Trill => '\uE566';

        public static SMuFLFontProfile CreateFromBinaryArray(byte[] byteArray)
        {
            using (var ms = new MemoryStream(byteArray))
                return CreateFromBinaryStream(ms);
        }

        public static SMuFLFontProfile CreateFromBinaryResource(Assembly assembly, string resourceFullName)
        {
            using (var stream = assembly.GetManifestResourceStream(resourceFullName))
                return CreateFromBinaryStream(stream);
        }

        public static SMuFLFontProfile CreateFromBinaryResource<TNamespace>(string resourceFileName)
        {
            var assembly = typeof(TNamespace).GetTypeInfo().Assembly;
            var resourceName = $"{typeof(TNamespace).Namespace}.{resourceFileName}";
            return CreateFromBinaryResource(assembly, resourceName);
        }

        public static SMuFLFontProfile CreateFromBinaryStream(Stream binaryStream)
        {
            var settings = new SharpSerializerBinarySettings(BinarySerializationMode.SizeOptimized);
            var serializer = new SharpSerializer(settings);

            var metadata = serializer.Deserialize(binaryStream) as ISMuFLFontMetadata;
            return new SMuFLFontProfile(metadata, LazySMuFLGlyphs.Instance);
        }

        public static SMuFLFontProfile CreateFromJsonResource(Assembly assembly, string resourceFullName, JSONLoadingModes loadingMode = JSONLoadingModes.LazyWithDynamicProxy)
        {
            using (var stream = assembly.GetManifestResourceStream(resourceFullName))
            using (var reader = new StreamReader(stream))
            {
                string result = reader.ReadToEnd();
                return CreateFromJsonString(result, loadingMode);
            }
        }

        public static SMuFLFontProfile CreateFromJsonResource<TNamespace>(string resourceFileName, JSONLoadingModes loadingMode = JSONLoadingModes.LazyWithDynamicProxy)
        {
            var assembly = typeof(TNamespace).GetTypeInfo().Assembly;
            var resourceName = $"{typeof(TNamespace).Namespace}.{resourceFileName}";
            return CreateFromJsonResource(assembly, resourceName, loadingMode);
        }

        public static SMuFLFontProfile CreateFromJsonStream(Stream jsonStream, JSONLoadingModes loadingMode = JSONLoadingModes.LazyWithDynamicProxy)
        {
            using (var reader = new StreamReader(jsonStream))
            {
                string json = reader.ReadToEnd();
                return CreateFromJsonString(json, loadingMode);
            }
        }

        public static SMuFLFontProfile CreateFromJsonString(string json, JSONLoadingModes loadingMode = JSONLoadingModes.LazyWithDynamicProxy)
        {
            ISMuFLFontMetadata metadata = null;
            if (loadingMode == JSONLoadingModes.Eager) metadata = JsonConvert.DeserializeObject<SMuFLFontMetadata>(json);
            if (loadingMode == JSONLoadingModes.LazyWithDynamicProxy) metadata = LazyLoadJsonProxy<ISMuFLFontMetadata>.Create(json);
            if (loadingMode == JSONLoadingModes.LazyWithStaticProxy) metadata = new LazySMuFLFontMetadata(json);
            if (metadata == null) throw new Exception($"Unknown loading mode {loadingMode}.");

            ISMuFLGlyphs glyphsInstance = null;
            if (loadingMode == JSONLoadingModes.Eager) glyphsInstance = LazySMuFLGlyphs.Instance;   //TODO: Eager loading
            if (loadingMode == JSONLoadingModes.LazyWithDynamicProxy) glyphsInstance = SMuFLGlyphs.Instance;
            if (loadingMode == JSONLoadingModes.LazyWithStaticProxy) glyphsInstance = LazySMuFLGlyphs.Instance;
            if (glyphsInstance == null) throw new Exception($"Unknown loading mode {loadingMode}.");

            return new SMuFLFontProfile(metadata, glyphsInstance);
        }

        public string BuildTimeSignature(int number) => timeSignatureNumberUtility.BuildNumber(number);

        public string BuildTupletNumber(int number) => tupletNumberUtility.BuildNumber(number);

        [Units(Units.Linespaces)]
        public double GetTimeSignatureNumberWidthLs(ISMuFLFontMetadata metadata, int number) => timeSignatureNumberUtility.GetNumberWidthLs(metadata, number);

        [Units(Units.Pixels)]
        public double GetTimeSignatureNumberWidthPx(ScoreRendererBase renderer, int number) => timeSignatureNumberUtility.GetNumberWidthPx(renderer, number);

        [Units(Units.Linespaces)]
        public double GetTupletNumberWidthLs(ISMuFLFontMetadata metadata, int number) => tupletNumberUtility.GetNumberWidthLs(metadata, number);

        [Units(Units.Pixels)]
        public double GetTupletNumberWidthPx(ScoreRendererBase renderer, int number) => tupletNumberUtility.GetNumberWidthPx(renderer, number);

        public enum JSONLoadingModes
        {
            /// <summary>
            /// Whole JSON document will be loaded at once
            /// </summary>
            Eager,

            /// <summary>
            /// JSON will be lazy loaded with static proxy
            /// </summary>
            LazyWithStaticProxy,

            /// <summary>
            /// JSON will be lazy loaded with dynamic proxy.
            /// This is using DispatchProxy implementation which can be unsupported on some platforms.
            /// </summary>
            LazyWithDynamicProxy
        }
    }
}
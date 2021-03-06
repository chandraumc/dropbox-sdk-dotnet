// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The delete batch error object</para>
    /// </summary>
    public class DeleteBatchError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<DeleteBatchError> Encoder = new DeleteBatchErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<DeleteBatchError> Decoder = new DeleteBatchErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="DeleteBatchError" />
        /// class.</para>
        /// </summary>
        public DeleteBatchError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is
        /// TooManyWriteOperations</para>
        /// </summary>
        public bool IsTooManyWriteOperations
        {
            get
            {
                return this is TooManyWriteOperations;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a TooManyWriteOperations, or <c>null</c>.</para>
        /// </summary>
        public TooManyWriteOperations AsTooManyWriteOperations
        {
            get
            {
                return this as TooManyWriteOperations;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="DeleteBatchError" />.</para>
        /// </summary>
        private class DeleteBatchErrorEncoder : enc.StructEncoder<DeleteBatchError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(DeleteBatchError value, enc.IJsonWriter writer)
            {
                if (value is TooManyWriteOperations)
                {
                    WriteProperty(".tag", "too_many_write_operations", writer, enc.StringEncoder.Instance);
                    TooManyWriteOperations.Encoder.EncodeFields((TooManyWriteOperations)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="DeleteBatchError" />.</para>
        /// </summary>
        private class DeleteBatchErrorDecoder : enc.UnionDecoder<DeleteBatchError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="DeleteBatchError" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override DeleteBatchError Create()
            {
                return new DeleteBatchError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override DeleteBatchError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "too_many_write_operations":
                        return TooManyWriteOperations.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>There are too many write operations in user's Dropbox. Please retry this
        /// request.</para>
        /// </summary>
        public sealed class TooManyWriteOperations : DeleteBatchError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<TooManyWriteOperations> Encoder = new TooManyWriteOperationsEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<TooManyWriteOperations> Decoder = new TooManyWriteOperationsDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="TooManyWriteOperations" />
            /// class.</para>
            /// </summary>
            private TooManyWriteOperations()
            {
            }

            /// <summary>
            /// <para>A singleton instance of TooManyWriteOperations</para>
            /// </summary>
            public static readonly TooManyWriteOperations Instance = new TooManyWriteOperations();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="TooManyWriteOperations" />.</para>
            /// </summary>
            private class TooManyWriteOperationsEncoder : enc.StructEncoder<TooManyWriteOperations>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(TooManyWriteOperations value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="TooManyWriteOperations" />.</para>
            /// </summary>
            private class TooManyWriteOperationsDecoder : enc.StructDecoder<TooManyWriteOperations>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="TooManyWriteOperations"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override TooManyWriteOperations Create()
                {
                    return TooManyWriteOperations.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : DeleteBatchError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return Other.Instance;
                }

            }

            #endregion
        }
    }
}

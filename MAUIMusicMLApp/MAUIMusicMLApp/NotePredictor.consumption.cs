﻿// This file was auto-generated by ML.NET Model Builder. 
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
namespace MAUIMusicMLApp
{
    public partial class NotePredictor
    {
        /// <summary>
        /// model input class for NotePredictor.
        /// </summary>
        #region model input class
        public class ModelInput
        {
            [ColumnName(@"Chorale")]
            public float Chorale { get; set; }

            [ColumnName(@"Key")]
            public float Key { get; set; }

            [ColumnName(@"Measure")]
            public float Measure { get; set; }

            [ColumnName(@"Note")]
            public string Note { get; set; }

            [ColumnName(@"60")]
            public float _60 { get; set; }

            [ColumnName(@"61")]
            public float _61 { get; set; }

            [ColumnName(@"62")]
            public float _62 { get; set; }

            [ColumnName(@"63")]
            public float _63 { get; set; }

            [ColumnName(@"64")]
            public float _64 { get; set; }

            [ColumnName(@"65")]
            public float _65 { get; set; }

            [ColumnName(@"66")]
            public float _66 { get; set; }

            [ColumnName(@"67")]
            public float _67 { get; set; }

            [ColumnName(@"68")]
            public float _68 { get; set; }

            [ColumnName(@"69")]
            public float _69 { get; set; }

            [ColumnName(@"70")]
            public float _70 { get; set; }

            [ColumnName(@"71")]
            public float _71 { get; set; }

            [ColumnName(@"72")]
            public float _72 { get; set; }

            [ColumnName(@"73")]
            public float _73 { get; set; }

            [ColumnName(@"74")]
            public float _74 { get; set; }

            [ColumnName(@"75")]
            public float _75 { get; set; }

            [ColumnName(@"76")]
            public float _76 { get; set; }

            [ColumnName(@"77")]
            public float _77 { get; set; }

            [ColumnName(@"78")]
            public float _78 { get; set; }

            [ColumnName(@"79")]
            public float _79 { get; set; }

        }

        #endregion

        /// <summary>
        /// model output class for NotePredictor.
        /// </summary>
        #region model output class
        public class ModelOutput
        {
            [ColumnName("PredictedLabel")]
            public string Prediction { get; set; }

            public float[] Score { get; set; }
        }

        #endregion

        private static string MLNetModelPath = Path.GetFullPath("NotePredictor.zip");

        public static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(() => CreatePredictEngine(), true);

        /// <summary>
        /// Use this method to predict on <see cref="ModelInput"/>.
        /// </summary>
        /// <param name="input">model input.</param>
        /// <returns><seealso cref=" ModelOutput"/></returns>
        public static ModelOutput Predict(ModelInput input)
        {
            var predEngine = PredictEngine.Value;
            return predEngine.Predict(input);
        }

        private static PredictionEngine<ModelInput, ModelOutput> CreatePredictEngine()
        {
            var mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load(MLNetModelPath, out var _);
            return mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
        }
    }
}

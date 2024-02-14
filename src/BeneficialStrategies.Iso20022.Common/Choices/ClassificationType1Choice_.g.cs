﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ClassificationType1Choice.  ISO2002 ID# _RdUQk9p-Ed-ak6NoX_4Aeg_-538549826.
//

using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the classification.
    /// </summary>
    [KnownType(typeof(ClassificationType1Choice.ClassificationFinancialInstrument))]
    [KnownType(typeof(ClassificationType1Choice.AlternateClassification))]
    [IsoId("_RdUQk9p-Ed-ak6NoX_4Aeg_-538549826")]
    [DisplayName("Classification Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ClassificationType1Choice_
    #else
    public abstract partial class ClassificationType1Choice_
    #endif
    {
    }
}

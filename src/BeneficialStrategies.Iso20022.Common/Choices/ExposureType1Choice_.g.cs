﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ExposureType1Choice.  ISO2002 ID# _QuOV8Np-Ed-ak6NoX_4Aeg_547934852.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
    /// Choice of format for the exposure information.
    /// </summary>
    [KnownType(typeof(ExposureType1Choice.Code))]
    [KnownType(typeof(ExposureType1Choice.Proprietary))]
    [IsoId("_QuOV8Np-Ed-ak6NoX_4Aeg_547934852")]
    [DisplayName("Exposure Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ExposureType1Choice_
    #else
    public abstract partial class ExposureType1Choice_
    #endif
    {
    }
}

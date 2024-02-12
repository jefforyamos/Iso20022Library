﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TaxCapacityParty1Choice.  ISO2002 ID# _Qv3UtNp-Ed-ak6NoX_4Aeg_948349513.
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
    /// Choice of format for the tax capacity information.
    /// </summary>
    [KnownType(typeof(TaxCapacityParty1Choice.Code))]
    [KnownType(typeof(TaxCapacityParty1Choice.Proprietary))]
    [IsoId("_Qv3UtNp-Ed-ak6NoX_4Aeg_948349513")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Tax Capacity Party 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TaxCapacityParty1Choice_
    #else
    public abstract partial class TaxCapacityParty1Choice_
    #endif
    {
    }
}

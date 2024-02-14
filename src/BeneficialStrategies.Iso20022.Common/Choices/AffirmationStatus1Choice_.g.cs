﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AffirmationStatus1Choice.  ISO2002 ID# _UaaT2Np-Ed-ak6NoX_4Aeg_674653876.
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
    /// Choice of format for the affirmation status.
    /// </summary>
    [KnownType(typeof(AffirmationStatus1Choice.Code))]
    [KnownType(typeof(AffirmationStatus1Choice.Proprietary))]
    [IsoId("_UaaT2Np-Ed-ak6NoX_4Aeg_674653876")]
    [DisplayName("Affirmation Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AffirmationStatus1Choice_
    #else
    public abstract partial class AffirmationStatus1Choice_
    #endif
    {
    }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyOrOperationalError1Choice.  ISO2002 ID# _kniH4-5NEeCisYr99QEiWA_-677861699.
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
    /// Report between the party reference data or an operational error.
    /// </summary>
    [KnownType(typeof(PartyOrOperationalError1Choice.PartyReport))]
    [KnownType(typeof(PartyOrOperationalError1Choice.OperationalError))]
    [IsoId("_kniH4-5NEeCisYr99QEiWA_-677861699")]
    [DisplayName("Party Or Operational Error 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyOrOperationalError1Choice_
    #else
    public abstract partial class PartyOrOperationalError1Choice_
    #endif
    {
    }
}

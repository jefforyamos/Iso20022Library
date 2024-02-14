﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CurrentOrDefaultReservation1Choice.  ISO2002 ID# _8IjoJKMgEeCJ6YNENx4h-w_-1597699286.
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
    /// Current or default reservation set by the member and managed by the transaction administrator.
    /// </summary>
    [KnownType(typeof(CurrentOrDefaultReservation1Choice.Current))]
    [KnownType(typeof(CurrentOrDefaultReservation1Choice.Default))]
    [IsoId("_8IjoJKMgEeCJ6YNENx4h-w_-1597699286")]
    [DisplayName("Current Or Default Reservation 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CurrentOrDefaultReservation1Choice_
    #else
    public abstract partial class CurrentOrDefaultReservation1Choice_
    #endif
    {
    }
}

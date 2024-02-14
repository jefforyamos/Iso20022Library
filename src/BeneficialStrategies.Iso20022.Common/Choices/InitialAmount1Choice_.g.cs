﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InitialAmount1Choice.  ISO2002 ID# _Ru9ewCDaEeWCLu74WLgP4w.
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
    /// Choice of an initial amount or number of pre-paid instalments.
    /// </summary>
    [KnownType(typeof(InitialAmount1Choice.InitialNumberOfInstalments))]
    [KnownType(typeof(InitialAmount1Choice.Amount))]
    [IsoId("_Ru9ewCDaEeWCLu74WLgP4w")]
    [DisplayName("Initial Amount 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InitialAmount1Choice_
    #else
    public abstract partial class InitialAmount1Choice_
    #endif
    {
    }
}

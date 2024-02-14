﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for UnderlyingContract1Choice.  ISO2002 ID# _opBo8NLJEeSdq5yU2aaSNw.
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
    /// Choice of the type of underlying contract.
    /// </summary>
    [KnownType(typeof(UnderlyingContract1Choice.Loan))]
    [KnownType(typeof(UnderlyingContract1Choice.Trade))]
    [IsoId("_opBo8NLJEeSdq5yU2aaSNw")]
    [DisplayName("Underlying Contract 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnderlyingContract1Choice_
    #else
    public abstract partial class UnderlyingContract1Choice_
    #endif
    {
    }
}

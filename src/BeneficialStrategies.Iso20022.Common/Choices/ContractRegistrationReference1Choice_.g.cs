﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ContractRegistrationReference1Choice.  ISO2002 ID# _tyufgdM-EeSDLevdaFPXHw.
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
    /// Reference details of the contract registration.
    /// </summary>
    [KnownType(typeof(ContractRegistrationReference1Choice.RegisteredContractIdentification))]
    [KnownType(typeof(ContractRegistrationReference1Choice.Contract))]
    [IsoId("_tyufgdM-EeSDLevdaFPXHw")]
    [DisplayName("Contract Registration Reference 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ContractRegistrationReference1Choice_
    #else
    public abstract partial class ContractRegistrationReference1Choice_
    #endif
    {
    }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ContractRegistrationReference2Choice.  ISO2002 ID# _KUfpwbMmEeueudaIbClZbQ.
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
    [KnownType(typeof(ContractRegistrationReference2Choice.RegisteredContractIdentification))]
    [KnownType(typeof(ContractRegistrationReference2Choice.Contract))]
    [IsoId("_KUfpwbMmEeueudaIbClZbQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Contract Registration Reference 2 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ContractRegistrationReference2Choice_
    #else
    public abstract partial class ContractRegistrationReference2Choice_
    #endif
    {
    }
}

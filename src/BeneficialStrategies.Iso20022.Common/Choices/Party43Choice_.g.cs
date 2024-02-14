﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Party43Choice.  ISO2002 ID# _BgdrHW49EeiU9cctagi5ow.
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
    /// Nature or use of the account.
    /// </summary>
    [KnownType(typeof(Party43Choice.OrganisationIdentification))]
    [KnownType(typeof(Party43Choice.FinancialInstitutionIdentification))]
    [IsoId("_BgdrHW49EeiU9cctagi5ow")]
    [DisplayName("Party 43 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Party43Choice_
    #else
    public abstract partial class Party43Choice_
    #endif
    {
    }
}

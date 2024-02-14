﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CollateralFlag13Choice.  ISO2002 ID# _J9q9scg5Eeu4ecZgAYuz5w.
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
    /// Data on collateral used for the securities lending transaction.
    /// </summary>
    [KnownType(typeof(CollateralFlag13Choice.Collateralised))]
    [KnownType(typeof(CollateralFlag13Choice.Uncollateralised))]
    [IsoId("_J9q9scg5Eeu4ecZgAYuz5w")]
    [DisplayName("Collateral Flag 13 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CollateralFlag13Choice_
    #else
    public abstract partial class CollateralFlag13Choice_
    #endif
    {
    }
}

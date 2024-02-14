﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AssetClassAttributes1Choice.  ISO2002 ID# _id4oJO94EeW7gabYEJmWIA.
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
    /// Asset class specific details of a derivative.
    /// </summary>
    [KnownType(typeof(AssetClassAttributes1Choice.Interest))]
    [KnownType(typeof(AssetClassAttributes1Choice.ForeignExchange))]
    [KnownType(typeof(AssetClassAttributes1Choice.Both))]
    [IsoId("_id4oJO94EeW7gabYEJmWIA")]
    [DisplayName("Asset Class Attributes 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AssetClassAttributes1Choice_
    #else
    public abstract partial class AssetClassAttributes1Choice_
    #endif
    {
    }
}

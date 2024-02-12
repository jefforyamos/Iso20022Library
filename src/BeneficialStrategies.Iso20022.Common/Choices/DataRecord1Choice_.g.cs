﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for DataRecord1Choice.  ISO2002 ID# _Gl7WgJb8Eeuc6pwKtqbEVQ.
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
    /// Contains the data record in either Binary or text format.
    /// </summary>
    [KnownType(typeof(DataRecord1Choice.Binary))]
    [KnownType(typeof(DataRecord1Choice.Text))]
    [IsoId("_Gl7WgJb8Eeuc6pwKtqbEVQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Data Record 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DataRecord1Choice_
    #else
    public abstract partial class DataRecord1Choice_
    #endif
    {
    }
}

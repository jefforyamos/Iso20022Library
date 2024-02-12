﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ResidenceLocation1Choice.  ISO2002 ID# _6QsqkpqlEeGSON8vddiWzQ_1947299018.
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
    /// Choice of location of a residence of a party.
    /// </summary>
    [KnownType(typeof(ResidenceLocation1Choice.Country))]
    [KnownType(typeof(ResidenceLocation1Choice.Area))]
    [IsoId("_6QsqkpqlEeGSON8vddiWzQ_1947299018")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Residence Location 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ResidenceLocation1Choice_
    #else
    public abstract partial class ResidenceLocation1Choice_
    #endif
    {
    }
}

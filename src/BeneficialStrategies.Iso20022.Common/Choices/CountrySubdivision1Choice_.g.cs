﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CountrySubdivision1Choice.  ISO2002 ID# _93jww3ltEeG7BsjMvd1mEw_-652907596.
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
    /// Choice of format for the legal jurisdiction.
    /// </summary>
    [KnownType(typeof(CountrySubdivision1Choice.Code))]
    [KnownType(typeof(CountrySubdivision1Choice.Proprietary))]
    [IsoId("_93jww3ltEeG7BsjMvd1mEw_-652907596")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Country Subdivision 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CountrySubdivision1Choice_
    #else
    public abstract partial class CountrySubdivision1Choice_
    #endif
    {
    }
}

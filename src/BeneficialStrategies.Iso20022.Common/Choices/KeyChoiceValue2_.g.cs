﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for KeyChoiceValue2.  ISO2002 ID# _Fav_cbTqEeeQy4o2AayYHg.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
    /// Element containing the key information.
    /// </summary>
    [KnownType(typeof(KeyChoiceValue2.EncryptedKeyValue))]
    [KnownType(typeof(KeyChoiceValue2.TRRelatedData))]
    [IsoId("_Fav_cbTqEeeQy4o2AayYHg")]
    [DisplayName("Key Choice Value")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record KeyChoiceValue2_
    #else
    public abstract partial class KeyChoiceValue2_
    #endif
    {
    }
}

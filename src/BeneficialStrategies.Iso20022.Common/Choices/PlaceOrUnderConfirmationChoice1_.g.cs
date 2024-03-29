﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PlaceOrUnderConfirmationChoice1.  ISO2002 ID# _97kuEnltEeG7BsjMvd1mEw_-1026438563.
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
    /// Choice between a location and codified form.
    /// </summary>
    [KnownType(typeof(PlaceOrUnderConfirmationChoice1.PlaceOfPresentation))]
    [KnownType(typeof(PlaceOrUnderConfirmationChoice1.PresentationUnderConfirmation))]
    [IsoId("_97kuEnltEeG7BsjMvd1mEw_-1026438563")]
    [DisplayName("Place Or Under Confirmation Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PlaceOrUnderConfirmationChoice1_
    #else
    public abstract partial class PlaceOrUnderConfirmationChoice1_
    #endif
    {
    }
}

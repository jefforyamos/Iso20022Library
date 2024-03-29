﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for StatementBasisCodeAndDSSCodeChoice.  ISO2002 ID# _Q7Cp8Np-Ed-ak6NoX_4Aeg_-1357896034.
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
    /// Choice between formats for the statement basis.
    /// </summary>
    [KnownType(typeof(StatementBasisCodeAndDSSCodeChoice.StatementBasisAsCode))]
    [KnownType(typeof(StatementBasisCodeAndDSSCodeChoice.StatementBasisAsDSS))]
    [IsoId("_Q7Cp8Np-Ed-ak6NoX_4Aeg_-1357896034")]
    [DisplayName("Statement Basis Code And DSS Code Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record StatementBasisCodeAndDSSCodeChoice_
    #else
    public abstract partial class StatementBasisCodeAndDSSCodeChoice_
    #endif
    {
    }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ChargeTaxBasisType1Choice.  ISO2002 ID# _AdIdYtokEeC60axPepSq7g_397232246.
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
    /// Choice of format for the charge tax basis.
    /// </summary>
    [KnownType(typeof(ChargeTaxBasisType1Choice.Code))]
    [KnownType(typeof(ChargeTaxBasisType1Choice.Proprietary))]
    [IsoId("_AdIdYtokEeC60axPepSq7g_397232246")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Charge Tax Basis Type 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ChargeTaxBasisType1Choice_
    #else
    public abstract partial class ChargeTaxBasisType1Choice_
    #endif
    {
    }
}

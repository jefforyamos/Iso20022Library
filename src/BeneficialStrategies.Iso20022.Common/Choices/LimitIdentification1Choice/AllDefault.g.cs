﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AllDefault.  ISO2002 ID# _73kl06MgEeCJ6YNENx4h-w_513549223.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.LimitIdentification1Choice
{
    /// <summary>
    /// Identification of all default limits.
    /// </summary>
    [IsoId("_73kl06MgEeCJ6YNENx4h-w_513549223")]
    [DisplayName("All Default")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record AllDefault : LimitIdentification1Choice_
    #else
    public partial class AllDefault : LimitIdentification1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a AllDefault instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public AllDefault( LimitType1Choice_ reqType )
        {
            Type = reqType;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Identification of a particular cash clearing system.
        /// </summary>
        [IsoId("_79Y59KMgEeCJ6YNENx4h-w_1467741043")]
        [DisplayName("System Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SysId")]
        #endif
        [IsoXmlTag("SysId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SystemIdentification2Choice_? SystemIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SystemIdentification2Choice_? SystemIdentification { get; init; } 
        #else
        public SystemIdentification2Choice_? SystemIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Nature of the risk management limit.
        /// </summary>
        [IsoId("_79Y59aMgEeCJ6YNENx4h-w_-939946563")]
        [DisplayName("Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Tp")]
        #endif
        [IsoXmlTag("Tp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required LimitType1Choice_ Type { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required LimitType1Choice_ Type { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public LimitType1Choice_ Type { get; init; } 
        #else
        public LimitType1Choice_ Type { get; set; } 
        #endif
        
        /// <summary>
        /// Owner of the account which is being queried.
        /// </summary>
        [IsoId("_79Y59qMgEeCJ6YNENx4h-w_1519150628")]
        [DisplayName("Account Owner")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AcctOwnr")]
        #endif
        [IsoXmlTag("AcctOwnr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public BranchAndFinancialInstitutionIdentification5? AccountOwner { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public BranchAndFinancialInstitutionIdentification5? AccountOwner { get; init; } 
        #else
        public BranchAndFinancialInstitutionIdentification5? AccountOwner { get; set; } 
        #endif
        
        /// <summary>
        /// Unique and unambiguous identification for the account between the account owner and the account servicer.
        /// </summary>
        [IsoId("_79Y596MgEeCJ6YNENx4h-w_-938620996")]
        [DisplayName("Account Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AcctId")]
        #endif
        [IsoXmlTag("AcctId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public AccountIdentification4Choice_? AccountIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AccountIdentification4Choice_? AccountIdentification { get; init; } 
        #else
        public AccountIdentification4Choice_? AccountIdentification { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Current.  ISO2002 ID# _8IjoJaMgEeCJ6YNENx4h-w_-2137818038.
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
namespace BeneficialStrategies.Iso20022.Choices.CurrentOrDefaultReservation1Choice
{
    /// <summary>
    /// Identification of the current reservation.
    /// </summary>
    [IsoId("_8IjoJaMgEeCJ6YNENx4h-w_-2137818038")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Current")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Current : CurrentOrDefaultReservation1Choice_
    #else
    public partial class Current : CurrentOrDefaultReservation1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Current instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Current( ReservationType1Choice_ reqType )
        {
            Type = reqType;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique identification of the reservation.
        /// </summary>
        [IsoId("_8IQtMKMgEeCJ6YNENx4h-w_996988035")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Reservation Identification")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? ReservationIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? ReservationIdentification { get; init; } 
        #else
        public System.String? ReservationIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Identification of a particular cash clearing system.
        /// </summary>
        [IsoId("_8IQtMaMgEeCJ6YNENx4h-w_-1950351602")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("System Identification")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SystemIdentification2Choice_? SystemIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SystemIdentification2Choice_? SystemIdentification { get; init; } 
        #else
        public SystemIdentification2Choice_? SystemIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Nature of the reservation.
        /// </summary>
        [IsoId("_8IQtMqMgEeCJ6YNENx4h-w_10956132")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Type")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ReservationType1Choice_ Type { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public ReservationType1Choice_ Type { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ReservationType1Choice_ Type { get; init; } 
        #else
        public ReservationType1Choice_ Type { get; set; } 
        #endif
        
        /// <summary>
        /// Owner of the account which is being queried.
        /// </summary>
        [IsoId("_8IQtM6MgEeCJ6YNENx4h-w_-1367726811")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Account Owner")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
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
        [IsoId("_8IQtNKMgEeCJ6YNENx4h-w_-1345665819")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Account Identification")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
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

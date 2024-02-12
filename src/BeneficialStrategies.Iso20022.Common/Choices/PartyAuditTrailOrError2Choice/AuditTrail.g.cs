﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AuditTrail.  ISO2002 ID# _HK0lEWjHEeiCUdTMLdZoIg.
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
namespace BeneficialStrategies.Iso20022.Choices.PartyAuditTrailOrError2Choice
{
    /// <summary>
    /// Provides the details of the audit trail data reported.
    /// </summary>
    [IsoId("_HK0lEWjHEeiCUdTMLdZoIg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Audit Trail")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record AuditTrail : PartyAuditTrailOrError2Choice_
    #else
    public partial class AuditTrail : PartyAuditTrailOrError2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a AuditTrail instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public AuditTrail( System.DateTime reqOperationTimeStamp,System.String reqInstructingUser )
        {
            OperationTimeStamp = reqOperationTimeStamp;
            InstructingUser = reqInstructingUser;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Individual record of the party audit trail.
        /// </summary>
        [IsoId("_GLdVoWjOEeiRg5NzP0jkQg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Record")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        public UpdateLogPartyRecord1Choice_? Record { get; init;  } // Warning: Don't know multiplicity.
        // ID for the above is _GLdVoWjOEeiRg5NzP0jkQg
        
        /// <summary>
        /// Timestamp of the change.
        /// </summary>
        [IsoId("_HZNmZ2jHEeiCUdTMLdZoIg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Operation Time Stamp")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODateTime OperationTimeStamp { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public System.DateTime OperationTimeStamp { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateTime OperationTimeStamp { get; init; } 
        #else
        public System.DateTime OperationTimeStamp { get; set; } 
        #endif
        
        /// <summary>
        /// User who instructed the change.
        /// </summary>
        [IsoId("_HZNmaWjHEeiCUdTMLdZoIg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Instructing User")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 256 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax256Text InstructingUser { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public System.String InstructingUser { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String InstructingUser { get; init; } 
        #else
        public System.String InstructingUser { get; set; } 
        #endif
        
        /// <summary>
        /// User who approved the change instructed by the instructing user.
        /// </summary>
        [IsoId("_HZNma2jHEeiCUdTMLdZoIg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Approving User")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 256 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax256Text? ApprovingUser { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? ApprovingUser { get; init; } 
        #else
        public System.String? ApprovingUser { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MaintenanceDelegation9.  ISO2002 ID# _JpuL0Q00EeqUVL7sB4m7NA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information on the delegation of a maintenance action or maintenance function.
/// </summary>
[IsoId("_JpuL0Q00EeqUVL7sB4m7NA")]
[DisplayName("Maintenance Delegation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MaintenanceDelegation9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MaintenanceDelegation9 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MaintenanceDelegation9( Response2Code reqResponse,TerminalManagementAction3Code reqDelegationType )
    {
        Response = reqResponse;
        DelegationType = reqDelegationType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Maintenance service to be delegated.
    /// </summary>
    [IsoId("_J1SioQ00EeqUVL7sB4m7NA")]
    [DisplayName("Maintenance Service")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MntncSvc")]
    #endif
    [IsoXmlTag("MntncSvc")]
    public DataSetCategory11Code? MaintenanceService { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _J1SioQ00EeqUVL7sB4m7NA
    
    /// <summary>
    /// Response of the MTM to the delegation of the maintenance service.
    /// </summary>
    [IsoId("_J1Siow00EeqUVL7sB4m7NA")]
    [DisplayName("Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rspn")]
    #endif
    [IsoXmlTag("Rspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Response2Code Response { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Response2Code Response { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Response2Code Response { get; init; } 
    #else
    public Response2Code Response { get; set; } 
    #endif
    
    /// <summary>
    /// Reason of the response of the MTM.
    /// </summary>
    [IsoId("_J1SipQ00EeqUVL7sB4m7NA")]
    [DisplayName("Response Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspnRsn")]
    #endif
    [IsoXmlTag("RspnRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ResponseReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ResponseReason { get; init; } 
    #else
    public System.String? ResponseReason { get; set; } 
    #endif
    
    /// <summary>
    /// Type of delegation action.
    /// </summary>
    [IsoId("_J1Sipw00EeqUVL7sB4m7NA")]
    [DisplayName("Delegation Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlgtnTp")]
    #endif
    [IsoXmlTag("DlgtnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TerminalManagementAction3Code DelegationType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TerminalManagementAction3Code DelegationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TerminalManagementAction3Code DelegationType { get; init; } 
    #else
    public TerminalManagementAction3Code DelegationType { get; set; } 
    #endif
    
    /// <summary>
    /// Subset of the terminal estate for the delegated actions, for instance for pilot or key deactivation). The subset may be expressed as a list of POI or terminal estate subset identifier.
    /// </summary>
    [IsoId("_J1SiqQ00EeqUVL7sB4m7NA")]
    [DisplayName("POI Subset")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POISubset")]
    #endif
    [IsoXmlTag("POISubset")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? POISubset { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? POISubset { get; init; } 
    #else
    public System.String? POISubset { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the parameters subset assigned by the MTM.
    /// </summary>
    [IsoId("_J1Siqw00EeqUVL7sB4m7NA")]
    [DisplayName("Delegation Scope Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlgtnScpId")]
    #endif
    [IsoXmlTag("DlgtnScpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? DelegationScopeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DelegationScopeIdentification { get; init; } 
    #else
    public System.String? DelegationScopeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// This element contains all information relevant to the DelegationScopeIdentification. The format of this element is out of scope of this definition.
    /// </summary>
    [IsoId("_J1SirQ00EeqUVL7sB4m7NA")]
    [DisplayName("Delegation Scope Definition")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlgtnScpDef")]
    #endif
    [IsoXmlTag("DlgtnScpDef")]
    [IsoSimpleType(IsoSimpleType.Max3000Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3000Binary? DelegationScopeDefinition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? DelegationScopeDefinition { get; init; } 
    #else
    public System.Byte[]? DelegationScopeDefinition { get; set; } 
    #endif
    
    /// <summary>
    /// This element contains the necessary information to secure the management of the Delegation. The format of this element is out of scope of this definition.
    /// </summary>
    [IsoId("_J1Sirw00EeqUVL7sB4m7NA")]
    [DisplayName("Delegation Proof")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlgtnProof")]
    #endif
    [IsoXmlTag("DlgtnProof")]
    [IsoSimpleType(IsoSimpleType.Max5000Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax5000Binary? DelegationProof { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? DelegationProof { get; init; } 
    #else
    public System.Byte[]? DelegationProof { get; set; } 
    #endif
    
    /// <summary>
    /// Protected proof of delegation.
    /// </summary>
    [IsoId("_J1SisQ00EeqUVL7sB4m7NA")]
    [DisplayName("Protected Delegation Proof")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctdDlgtnProof")]
    #endif
    [IsoXmlTag("PrtctdDlgtnProof")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType23? ProtectedDelegationProof { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType23? ProtectedDelegationProof { get; init; } 
    #else
    public ContentInformationType23? ProtectedDelegationProof { get; set; } 
    #endif
    
    /// <summary>
    /// Association of the TM identifier and the MTM identifier of a POI.
    /// </summary>
    [IsoId("_J1Sisw00EeqUVL7sB4m7NA")]
    [DisplayName("POI Identification Association")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POIIdAssoctn")]
    #endif
    [IsoXmlTag("POIIdAssoctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MaintenanceIdentificationAssociation1? POIIdentificationAssociation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MaintenanceIdentificationAssociation1? POIIdentificationAssociation { get; init; } 
    #else
    public MaintenanceIdentificationAssociation1? POIIdentificationAssociation { get; set; } 
    #endif
    
    
    #nullable disable
    
}

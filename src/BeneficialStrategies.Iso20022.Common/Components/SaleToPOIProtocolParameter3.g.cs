﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SaleToPOIProtocolParameter3.  ISO2002 ID# _tmvvQXIVEe2OqYulmHWukQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Configuration parameters to communicate with a sale system.
/// </summary>
public partial record SaleToPOIProtocolParameter3
{
    #nullable enable
    
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    public required TerminalManagementAction3Code ActionType { get; init; } 
    /// <summary>
    /// Identification of the merchant.
    /// </summary>
    public Organisation26? MerchantIdentification { get; init; } 
    /// <summary>
    /// Version of the parameters.
    /// </summary>
    public required IsoMax256Text Version { get; init; } 
    /// <summary>
    /// Identification used to retrieve HostCommunicationParameters.
    /// </summary>
    public required IsoMax35Text HostIdentification { get; init; } 
    /// <summary>
    /// Identification of the POI during communication with sale system.
    /// </summary>
    public IsoMax35Text? MerchantPOIIdentification { get; init; } 
    /// <summary>
    /// Identification of the SaleSystem connected to the POI.
    /// </summary>
    public IsoMax35Text? SaleIdentification { get; init; } 
    /// <summary>
    /// Identify a message that a Sale system could send to the POI system.
    /// </summary>
    public RetailerMessage1Code[] AllowedSaleMessage { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Identify a message that a POI system could send to the Sale system.
    /// </summary>
    public RetailerMessage1Code[] AllowedPOIMessage { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Identify a service that a POI system could support to the Sale system.
    /// </summary>
    public RetailerService2Code[] AllowedPOIService { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Identify a device request that a Sale system could ask to the POI system.
    /// </summary>
    public RetailerService8Code[] AllowedSaleDevice { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// List of types that the receiver supports and that the sender could use as type of an ExternallyDefinedData message component.
    /// </summary>
    public IsoMax1025Text[] ExternallyTypeSupported { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for VehicleRentalService1.  ISO2002 ID# _9dqxI_TdEeife6veM7daYw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Vehicle rental service provides detailed vehicle rental information.
/// </summary>
public partial record VehicleRentalService1
{
    #nullable enable
    
    /// <summary>
    /// Company in charge of a vehicle rental service.
    /// </summary>
    public VehicleRentalCompany1? VehicleRentalCompany { get; init; } 
    /// <summary>
    /// Customer renting a vehicle.
    /// </summary>
    public VehicleRentalCustomer1? Customer { get; init; } 
    /// <summary>
    /// Provides the identifier assigned by the card acceptor that best categorizes the items being purchased in a standardized commodity group.
    /// </summary>
    public IsoMax35Text? SummaryCommodityIdentification { get; init; } 
    /// <summary>
    /// Agreement (contract) related to a vehicle rental service.
    /// </summary>
    public VehicleRentalAgreement1? RentalAgreement { get; init; } 
    /// <summary>
    /// Invoice related to a vehicle rental service.
    /// </summary>
    public VehicleRentalInvoice1? RentalInvoice { get; init; } 
    /// <summary>
    /// Additional user-defined data pertaining to the vehicle rental. 
    /// </summary>
    public IsoMax350Text? AdditionalData { get; init; } 
    
    #nullable disable
}

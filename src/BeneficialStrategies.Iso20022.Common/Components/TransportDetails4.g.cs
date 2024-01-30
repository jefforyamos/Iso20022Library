﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransportDetails4.  ISO2002 ID# _2ZcofzckEeSaC-PiOaz_KQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information on the shipment date, the charges, the routing and the goods described in the transport document.
/// </summary>
public partial record TransportDetails4
{
    #nullable enable
    
    /// <summary>
    /// Reference to the identification of the underlying transport document.
    /// </summary>
    public DocumentIdentification7? TransportDocumentReference { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Goods that are transported.
    /// </summary>
    public TransportedGoods1? TransportedGoods { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Physical packaging of goods for transport.
    /// </summary>
    public Consignment3? Consignment { get; init; } 
    /// <summary>
    /// Information related to the conveyance of goods.
    /// </summary>
    public required TransportMeans6 RoutingSummary { get; init; } 
    /// <summary>
    /// Shipment date, actual or proposed.
    /// </summary>
    public required IShipmentDate1Choice ShipmentDate { get; init; } 
    /// <summary>
    /// Charges related to the conveyance of goods.
    /// </summary>
    public Charge25? FreightCharges { get; init; } 
    /// <summary>
    /// Specifies the applicable Incoterm and associated location.
    /// </summary>
    public Incoterms4? Incoterms { get; init; } 
    
    #nullable disable
}

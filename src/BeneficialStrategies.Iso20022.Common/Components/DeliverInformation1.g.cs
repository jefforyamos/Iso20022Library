﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DeliverInformation1.  ISO2002 ID# _VOHou9p-Ed-ak6NoX_4Aeg_1212568563.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters applied to the settlement of a security transfer.
/// </summary>
public partial record DeliverInformation1
     : IIsoXmlSerilizable<DeliverInformation1>
{
    #nullable enable
    
    /// <summary>
    /// Chain of parties involved in the settlement of a transaction.
    /// </summary>
    public required DeliveringPartiesAndAccount1 SettlementPartiesDetails { get; init; } 
    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    public required IsoYesNoIndicator PhysicalTransferIndicator { get; init; } 
    /// <summary>
    /// Parameters of a physical delivery.
    /// </summary>
    public DeliveryParameters2? PhysicalTransferDetails { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "SttlmPtiesDtls", xmlNamespace );
        SettlementPartiesDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "PhysTrfInd", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(PhysicalTransferIndicator)); // data type YesNoIndicator System.String
        writer.WriteEndElement();
        if (PhysicalTransferDetails is DeliveryParameters2 PhysicalTransferDetailsValue)
        {
            writer.WriteStartElement(null, "PhysTrfDtls", xmlNamespace );
            PhysicalTransferDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static DeliverInformation1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

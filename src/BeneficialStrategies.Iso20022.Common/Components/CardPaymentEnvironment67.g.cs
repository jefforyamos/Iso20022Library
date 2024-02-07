﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentEnvironment67.  ISO2002 ID# _Qu7MEbCkEeapjPTKZHuM2w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the transaction.
/// </summary>
public partial record CardPaymentEnvironment67
     : IIsoXmlSerilizable<CardPaymentEnvironment67>
{
    #nullable enable
    
    /// <summary>
    /// Acquirer involved in the card payment reconciliation.
    /// </summary>
    public required Acquirer4 Acquirer { get; init; } 
    /// <summary>
    /// Identification of the merchant requesting the reconciliation.
    /// </summary>
    public GenericIdentification53? MerchantIdentification { get; init; } 
    /// <summary>
    /// Identification of the POI (Point Of Interaction) requesting the reconciliation.
    /// </summary>
    public GenericIdentification53? POIIdentification { get; init; } 
    /// <summary>
    /// Data related to the components of the POI (Point Of Interaction) that have been performed the payment transactions.
    /// </summary>
    public PointOfInteractionComponent7? POIComponent { get; init; } 
    
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
        writer.WriteStartElement(null, "Acqrr", xmlNamespace );
        Acquirer.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (MerchantIdentification is GenericIdentification53 MerchantIdentificationValue)
        {
            writer.WriteStartElement(null, "MrchntId", xmlNamespace );
            MerchantIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (POIIdentification is GenericIdentification53 POIIdentificationValue)
        {
            writer.WriteStartElement(null, "POIId", xmlNamespace );
            POIIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (POIComponent is PointOfInteractionComponent7 POIComponentValue)
        {
            writer.WriteStartElement(null, "POICmpnt", xmlNamespace );
            POIComponentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CardPaymentEnvironment67 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentTransaction102.  ISO2002 ID# _z_uScQ0QEeq334Noltn0LA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the original transaction.
/// </summary>
public partial record CardPaymentTransaction102
     : IIsoXmlSerilizable<CardPaymentTransaction102>
{
    #nullable enable
    
    /// <summary>
    /// Global reference of the sale transaction for the sale system.
    /// </summary>
    public IsoMax35Text? SaleReferenceIdentification { get; init; } 
    /// <summary>
    /// Unique identification of the transaction assigned by the POI (Point Of Interaction).
    /// </summary>
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    public required GenericIdentification32 POIIdentification { get; init; } 
    /// <summary>
    /// Link to a previous currency conversion.
    /// </summary>
    public CurrencyConversion18? CurrencyConversion { get; init; } 
    
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
        if (SaleReferenceIdentification is IsoMax35Text SaleReferenceIdentificationValue)
        {
            writer.WriteStartElement(null, "SaleRefId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(SaleReferenceIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "TxId", xmlNamespace );
        TransactionIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "POIId", xmlNamespace );
        POIIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (CurrencyConversion is CurrencyConversion18 CurrencyConversionValue)
        {
            writer.WriteStartElement(null, "CcyConvs", xmlNamespace );
            CurrencyConversionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CardPaymentTransaction102 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

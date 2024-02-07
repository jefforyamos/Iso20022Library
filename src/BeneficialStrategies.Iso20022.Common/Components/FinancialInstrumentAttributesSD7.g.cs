﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstrumentAttributesSD7.  ISO2002 ID# _1esTQDL3EeKU9IrkkToqcw_-24344462.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding underlying security details.
/// </summary>
public partial record FinancialInstrumentAttributesSD7
     : IIsoXmlSerilizable<FinancialInstrumentAttributesSD7>
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    public required IsoMax350Text PlaceAndName { get; init; } 
    /// <summary>
    /// Name of the issuer.
    /// </summary>
    public IsoMax70Text? IssuerDescription { get; init; } 
    /// <summary>
    /// Country of incorporation of the issuer.
    /// </summary>
    public CountryCode? CountryOfIncorporation { get; init; } 
    /// <summary>
    /// Indicates if the stock exchange associated to place of listing code is primary.
    /// </summary>
    public IsoYesNoIndicator? PrimaryExchangeFlag { get; init; } 
    /// <summary>
    /// Indicates whether the event has been registered with US Securities Exchange Commission (SEC).
    /// </summary>
    public IsoYesNoIndicator? SECRegisteredFlag { get; init; } 
    
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
        writer.WriteStartElement(null, "PlcAndNm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax350Text(PlaceAndName)); // data type Max350Text System.String
        writer.WriteEndElement();
        if (IssuerDescription is IsoMax70Text IssuerDescriptionValue)
        {
            writer.WriteStartElement(null, "IssrDesc", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(IssuerDescriptionValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
        if (CountryOfIncorporation is CountryCode CountryOfIncorporationValue)
        {
            writer.WriteStartElement(null, "CtryOfIncorprtn", xmlNamespace );
            writer.WriteValue(CountryOfIncorporationValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (PrimaryExchangeFlag is IsoYesNoIndicator PrimaryExchangeFlagValue)
        {
            writer.WriteStartElement(null, "PmryXchgFlg", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(PrimaryExchangeFlagValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (SECRegisteredFlag is IsoYesNoIndicator SECRegisteredFlagValue)
        {
            writer.WriteStartElement(null, "SECRegdFlg", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(SECRegisteredFlagValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
    }
    public static FinancialInstrumentAttributesSD7 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionQuantitySD1.  ISO2002 ID# _1SxXJTL3EeKU9IrkkToqcw_-1416431204.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action securities quantity details.
/// </summary>
public partial record CorporateActionQuantitySD1
     : IIsoXmlSerilizable<CorporateActionQuantitySD1>
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    public required IsoMax350Text PlaceAndName { get; init; } 
    /// <summary>
    /// Represents "subscription base" (Quantity2) and "subscription disbursed" (Quantity1) quantity elements. "Subscription base quantity" is the quantity of the rights security that forms the basis for calculating the payout. It is located on the distribution announcement, with the rights subscription announcement following later. "Subscription disbursed quantity" is the quantity of securities received in the security payout. It is located on the distribution announcement, with the rights subscription announcement following later.
    /// </summary>
    public RatioFormat13Choice_? SubscriptionQuantity { get; init; } 
    
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
        if (SubscriptionQuantity is RatioFormat13Choice_ SubscriptionQuantityValue)
        {
            writer.WriteStartElement(null, "SbcptQty", xmlNamespace );
            SubscriptionQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CorporateActionQuantitySD1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

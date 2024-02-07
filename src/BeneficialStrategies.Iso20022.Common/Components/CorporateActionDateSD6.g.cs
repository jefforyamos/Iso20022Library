﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionDateSD6.  ISO2002 ID# _CglNgGG6EeORiK3bBeBzGg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action date details.
/// </summary>
public partial record CorporateActionDateSD6
     : IIsoXmlSerilizable<CorporateActionDateSD6>
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    public required IsoMax350Text PlaceAndName { get; init; } 
    /// <summary>
    /// Date on which called positions are moved into either a segregated account or a DTC Contra CUSIP(s).
    /// </summary>
    public IsoISODate? LotteryDate { get; init; } 
    
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
        if (LotteryDate is IsoISODate LotteryDateValue)
        {
            writer.WriteStartElement(null, "LtryDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(LotteryDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
    }
    public static CorporateActionDateSD6 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

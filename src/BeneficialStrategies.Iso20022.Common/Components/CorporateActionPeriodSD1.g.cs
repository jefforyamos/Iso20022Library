﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionPeriodSD1.  ISO2002 ID# _1TE5JjL3EeKU9IrkkToqcw_-513074553.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action details periods details.
/// </summary>
public partial record CorporateActionPeriodSD1
     : IIsoXmlSerilizable<CorporateActionPeriodSD1>
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    public required IsoMax350Text PlaceAndName { get; init; } 
    /// <summary>
    /// Period during which the securities can be submitted to Reorganisation deposit service at DTC (The Depository Trust Corporation). DTC First Day for Reorg Deposit (start date) is the day on which security is eligible for reorganisation deposit service at DTC. DTC Last Day for Reorg Deposit is the last day on which securities are eligible to be submitted for reorganisation deposit service at DTC.
    /// </summary>
    public Period3? DTCReorganisationDepositPeriod { get; init; } 
    /// <summary>
    /// Period during which the co-depositories deliveries are suspended at DTC (The Depository Trust Corporation). DTC Last Day for Depository Delivery (start date) - the last day on which depository deliveries will be accepted. DTC Chill Release Day for Depository Delivery (end date) - day when chill is released and depositories can resume delivery activities.
    /// </summary>
    public Period3? DTCChillPeriodForDepositoryDelivery { get; init; } 
    
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
        if (DTCReorganisationDepositPeriod is Period3 DTCReorganisationDepositPeriodValue)
        {
            writer.WriteStartElement(null, "DTCReorgDpstPrd", xmlNamespace );
            DTCReorganisationDepositPeriodValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DTCChillPeriodForDepositoryDelivery is Period3 DTCChillPeriodForDepositoryDeliveryValue)
        {
            writer.WriteStartElement(null, "DTCChillPrdForDpstryDlvry", xmlNamespace );
            DTCChillPeriodForDepositoryDeliveryValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CorporateActionPeriodSD1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

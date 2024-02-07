﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for HoldingBalance3.  ISO2002 ID# _QZElVtp-Ed-ak6NoX_4Aeg_1354170270.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Net position of a segregated holding of a single security within the overall position held in the securities account, eg, sub-balance per status.
/// </summary>
public partial record HoldingBalance3
     : IIsoXmlSerilizable<HoldingBalance3>
{
    #nullable enable
    
    /// <summary>
    /// Total quantity of financial instrument for the referenced holding.
    /// </summary>
    public UnitOrFaceAmountChoice_? Balance { get; init; } 
    /// <summary>
    /// Reason a security is not available or additional information about the financial instrument for which the balance is given, for example, unregistered, registered in nominee name.
    /// </summary>
    public SecuritiesEntryType2Code? BalanceType { get; init; } 
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    public SafekeepingPlaceFormatChoice_? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Date of the entitlement.
    /// </summary>
    public IsoISODate? Date { get; init; } 
    
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
        if (Balance is UnitOrFaceAmountChoice_ BalanceValue)
        {
            writer.WriteStartElement(null, "Bal", xmlNamespace );
            BalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (BalanceType is SecuritiesEntryType2Code BalanceTypeValue)
        {
            writer.WriteStartElement(null, "BalTp", xmlNamespace );
            writer.WriteValue(BalanceTypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (SafekeepingPlace is SafekeepingPlaceFormatChoice_ SafekeepingPlaceValue)
        {
            writer.WriteStartElement(null, "SfkpgPlc", xmlNamespace );
            SafekeepingPlaceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Date is IsoISODate DateValue)
        {
            writer.WriteStartElement(null, "Dt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(DateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
    }
    public static HoldingBalance3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionGeneralInformation98.  ISO2002 ID# _cjsaH5KQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General information about the corporate action event.
/// </summary>
public partial record CorporateActionGeneralInformation98
     : IIsoXmlSerilizable<CorporateActionGeneralInformation98>
{
    #nullable enable
    
    /// <summary>
    /// Reference assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    public required IsoRestrictedFINXMax16Text CorporateActionEventIdentification { get; init; } 
    /// <summary>
    /// Official and unique reference assigned by the official central body/entity within each market at the beginning of a corporate action event.
    /// </summary>
    public IsoRestrictedFINXMax16Text? OfficialCorporateActionEventIdentification { get; init; } 
    /// <summary>
    /// Reference assigned by a court to a class action.
    /// </summary>
    public IsoRestrictedFINXMax16Text? ClassActionNumber { get; init; } 
    /// <summary>
    /// Type of corporate action event.
    /// </summary>
    public required CorporateActionEventType41Choice_ EventType { get; init; } 
    /// <summary>
    /// Identification of the security concerned by the corporate action.
    /// </summary>
    public required SecurityIdentification20 FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Type of intermediates securities distribution.
    /// </summary>
    public IntermediateSecuritiesDistributionTypeFormat17Choice_? IntermediateSecuritiesDistributionType { get; init; } 
    /// <summary>
    /// Fractional quantity resulting from an event which will be paid with cash in lieu.
    /// </summary>
    public FinancialInstrumentQuantity15Choice_? FractionalQuantity { get; init; } 
    
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
        writer.WriteStartElement(null, "CorpActnEvtId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax16Text(CorporateActionEventIdentification)); // data type RestrictedFINXMax16Text System.String
        writer.WriteEndElement();
        if (OfficialCorporateActionEventIdentification is IsoRestrictedFINXMax16Text OfficialCorporateActionEventIdentificationValue)
        {
            writer.WriteStartElement(null, "OffclCorpActnEvtId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax16Text(OfficialCorporateActionEventIdentificationValue)); // data type RestrictedFINXMax16Text System.String
            writer.WriteEndElement();
        }
        if (ClassActionNumber is IsoRestrictedFINXMax16Text ClassActionNumberValue)
        {
            writer.WriteStartElement(null, "ClssActnNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax16Text(ClassActionNumberValue)); // data type RestrictedFINXMax16Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "EvtTp", xmlNamespace );
        EventType.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "FinInstrmId", xmlNamespace );
        FinancialInstrumentIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (IntermediateSecuritiesDistributionType is IntermediateSecuritiesDistributionTypeFormat17Choice_ IntermediateSecuritiesDistributionTypeValue)
        {
            writer.WriteStartElement(null, "IntrmdtSctiesDstrbtnTp", xmlNamespace );
            IntermediateSecuritiesDistributionTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (FractionalQuantity is FinancialInstrumentQuantity15Choice_ FractionalQuantityValue)
        {
            writer.WriteStartElement(null, "FrctnlQty", xmlNamespace );
            FractionalQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CorporateActionGeneralInformation98 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

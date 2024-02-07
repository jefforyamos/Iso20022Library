﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FundSettlementParameters4.  ISO2002 ID# _QVV76dp-Ed-ak6NoX_4Aeg_1594715500.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters applied to the settlement of a security.
/// </summary>
public partial record FundSettlementParameters4
     : IIsoXmlSerilizable<FundSettlementParameters4>
{
    #nullable enable
    
    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    public IsoISODate? SettlementDate { get; init; } 
    /// <summary>
    /// Place where the settlement of transaction will take place. In the context of the investment funds, the place of settlement is the transfer agent, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    public required PartyIdentification2Choice_ SettlementPlace { get; init; } 
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository or an International Central Securities Depository.
    /// </summary>
    public PartyIdentification2Choice_? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Identification of a specific system or set of rules and/or processes to be applied at the settlement place.
    /// </summary>
    public IsoMax35Text? SecuritiesSettlementSystemIdentification { get; init; } 
    /// <summary>
    /// Chain of parties involved in the settlement of a transaction resulting in the movement of a security from one account to another.
    /// </summary>
    public required ReceivingPartiesAndAccount3 ReceivingSideDetails { get; init; } 
    /// <summary>
    /// Chain of parties involved in the settlement of a transaction resulting in the movement of a security from one account to another.
    /// </summary>
    public DeliveringPartiesAndAccount3? DeliveringSideDetails { get; init; } 
    
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
        if (SettlementDate is IsoISODate SettlementDateValue)
        {
            writer.WriteStartElement(null, "SttlmDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(SettlementDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SttlmPlc", xmlNamespace );
        SettlementPlace.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SafekeepingPlace is PartyIdentification2Choice_ SafekeepingPlaceValue)
        {
            writer.WriteStartElement(null, "SfkpgPlc", xmlNamespace );
            SafekeepingPlaceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecuritiesSettlementSystemIdentification is IsoMax35Text SecuritiesSettlementSystemIdentificationValue)
        {
            writer.WriteStartElement(null, "SctiesSttlmSysId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(SecuritiesSettlementSystemIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "RcvgSdDtls", xmlNamespace );
        ReceivingSideDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (DeliveringSideDetails is DeliveringPartiesAndAccount3 DeliveringSideDetailsValue)
        {
            writer.WriteStartElement(null, "DlvrgSdDtls", xmlNamespace );
            DeliveringSideDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static FundSettlementParameters4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

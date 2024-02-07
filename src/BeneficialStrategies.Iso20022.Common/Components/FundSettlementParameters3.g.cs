﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FundSettlementParameters3.  ISO2002 ID# _QVV74tp-Ed-ak6NoX_4Aeg_1340706993.
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
public partial record FundSettlementParameters3
     : IIsoXmlSerilizable<FundSettlementParameters3>
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
    /// Place requested as the place of safekeeping.
    /// </summary>
    public PartyIdentification2Choice_? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Identifies the securities settlement system to be used.
    /// </summary>
    public IsoMax35Text? SecuritiesSettlementSystemIdentification { get; init; } 
    /// <summary>
    /// Chain of parties involved in the settlement of a transaction resulting in the movement of a security from one account to another.
    /// </summary>
    public ReceivingPartiesAndAccount3? ReceivingSideDetails { get; init; } 
    /// <summary>
    /// Chain of parties involved in the settlement of a transaction resulting in the movement of a security from one account to another.
    /// </summary>
    public required DeliveringPartiesAndAccount3 DeliveringSideDetails { get; init; } 
    
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
        if (ReceivingSideDetails is ReceivingPartiesAndAccount3 ReceivingSideDetailsValue)
        {
            writer.WriteStartElement(null, "RcvgSdDtls", xmlNamespace );
            ReceivingSideDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "DlvrgSdDtls", xmlNamespace );
        DeliveringSideDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static FundSettlementParameters3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

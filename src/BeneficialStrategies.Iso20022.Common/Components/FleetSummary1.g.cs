﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FleetSummary1.  ISO2002 ID# _otojUPikEeiJaN6-Lf-c_w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Supplies additional transaction information for fleet transactions.
/// </summary>
public partial record FleetSummary1
     : IIsoXmlSerilizable<FleetSummary1>
{
    #nullable enable
    
    /// <summary>
    /// Contains driver-related information.
    /// </summary>
    public Driver1? Driver { get; init; } 
    /// <summary>
    /// Vehicle belonging to the fleet.
    /// </summary>
    public Vehicle5? Vehicle { get; init; } 
    /// <summary>
    /// Second card presented for the payment transaction.
    /// </summary>
    public PlainCardData20? DriverOrVehicleCard { get; init; } 
    /// <summary>
    /// Indicates whether or not fuel or fleet data prompting should occur. 
    /// </summary>
    public IsoMax1Number? CardFuelPromptCode { get; init; } 
    /// <summary>
    /// Currently known as "TransactionNumber". An identification code assigned by an agent.  This code can be used after applying for and awaiting the appropriate prompt value to be defined.
    /// </summary>
    public IsoMax35Text? AgentFuelPromptCode { get; init; } 
    /// <summary>
    /// Contains the details related to an individual trip. 
    /// </summary>
    public TripInformation1? TripInformation { get; init; } 
    /// <summary>
    /// Indicates the amenities available at the location where the merchant actually performed the transaction.
    /// </summary>
    public LocalAmenity1? LocalAmenity { get; init; } 
    /// <summary>
    /// Contains information related specifically to the transaction.
    /// </summary>
    public PaymentTransaction117? TransactionRelatedData { get; init; } 
    /// <summary>
    /// Contains additional fleet summary data.
    /// </summary>
    public AdditionalInformation19? AdditionalData { get; init; } 
    
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
        if (Driver is Driver1 DriverValue)
        {
            writer.WriteStartElement(null, "Drvr", xmlNamespace );
            DriverValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Vehicle is Vehicle5 VehicleValue)
        {
            writer.WriteStartElement(null, "Vhcl", xmlNamespace );
            VehicleValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DriverOrVehicleCard is PlainCardData20 DriverOrVehicleCardValue)
        {
            writer.WriteStartElement(null, "DrvrOrVhclCard", xmlNamespace );
            DriverOrVehicleCardValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CardFuelPromptCode is IsoMax1Number CardFuelPromptCodeValue)
        {
            writer.WriteStartElement(null, "CardFuelPrmptCd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax1Number(CardFuelPromptCodeValue)); // data type Max1Number System.UInt64
            writer.WriteEndElement();
        }
        if (AgentFuelPromptCode is IsoMax35Text AgentFuelPromptCodeValue)
        {
            writer.WriteStartElement(null, "AgtFuelPrmptCd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(AgentFuelPromptCodeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (TripInformation is TripInformation1 TripInformationValue)
        {
            writer.WriteStartElement(null, "TripInf", xmlNamespace );
            TripInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LocalAmenity is LocalAmenity1 LocalAmenityValue)
        {
            writer.WriteStartElement(null, "LclAmnty", xmlNamespace );
            LocalAmenityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TransactionRelatedData is PaymentTransaction117 TransactionRelatedDataValue)
        {
            writer.WriteStartElement(null, "TxRltdData", xmlNamespace );
            TransactionRelatedDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalData is AdditionalInformation19 AdditionalDataValue)
        {
            writer.WriteStartElement(null, "AddtlData", xmlNamespace );
            AdditionalDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static FleetSummary1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

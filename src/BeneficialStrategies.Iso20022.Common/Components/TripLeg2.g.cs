﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TripLeg2.  ISO2002 ID# _k7Q5QZJGEeuuktRxxQZoNQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Supplies additional transaction information for travel transactions.
/// </summary>
public partial record TripLeg2
     : IIsoXmlSerilizable<TripLeg2>
{
    #nullable enable
    
    /// <summary>
    /// Identifies the specific occurrence of trip leg data. 
    /// </summary>
    public IsoMax35NumericText? SequenceNumber { get; init; } 
    /// <summary>
    /// Details of the ticket.
    /// </summary>
    public Ticket2? Ticket { get; init; } 
    /// <summary>
    /// Provides the document type and reference information.
    /// </summary>
    public DocumentReference1? Document { get; init; } 
    /// <summary>
    /// Contains identification of the rail server procedure or the order in which service was booked or cancellation was done.
    /// </summary>
    public IsoMax35Text? ProcedureReference { get; init; } 
    /// <summary>
    /// Type of transportation.
    /// </summary>
    public TransportType1Code? TransportType { get; init; } 
    /// <summary>
    /// Other type of transportation.
    /// </summary>
    public IsoMax35Text? OtherTransportType { get; init; } 
    /// <summary>
    /// Provides the identifier assigned by the card acceptor that best categorizes the items being purchased in a standardized commodity group.
    /// </summary>
    public IsoMax4Text? CommodityCode { get; init; } 
    /// <summary>
    /// Identification of transportation carrier.
    /// </summary>
    public CarrierIdentification1? Carrier { get; init; } 
    /// <summary>
    /// Route number as specified by the transportation carrier (for example, flight number, bus number, train route or number, etc.)
    /// </summary>
    public IsoMax35Text? RouteNumber { get; init; } 
    /// <summary>
    /// Indicates the service class (for example, coach or first class).
    /// </summary>
    public IsoMax35Text? ServiceClass { get; init; } 
    /// <summary>
    /// Contains departure location, date and time. 
    /// </summary>
    public DepartureOrArrival1? Departure { get; init; } 
    /// <summary>
    /// Contains arrival location, date and time. 
    /// </summary>
    public DepartureOrArrival1? Arrival { get; init; } 
    /// <summary>
    /// Duration of the trip.
    /// </summary>
    public IsoMax4NumericText? Duration { get; init; } 
    /// <summary>
    /// Indicator that specifies whether the mode of transportation was a direct or non-direct route on the same ticket number.
    /// </summary>
    public IsoTrueFalseIndicator? StopOverIndicator { get; init; } 
    /// <summary>
    /// Indicates a non-direct route between the origin and the destination. 
    /// </summary>
    public IsoMax35Text? NonDirectRouteCode { get; init; } 
    /// <summary>
    /// Code that transportation companies assign to a particular ticket type, such as business class or discounted or non-refundable tickets. 
    /// </summary>
    public IsoMax35Text? FairBasisCode { get; init; } 
    /// <summary>
    /// Indicates whether or not insurance was purchased. 
    /// </summary>
    public IsoTrueFalseIndicator? InsuranceIndicator { get; init; } 
    /// <summary>
    /// Contains trip leg amount information. 
    /// </summary>
    public AmountDetails2? TripLegAmount { get; init; } 
    /// <summary>
    /// Indicates reason for the credit to the cardholder.  Includes: ancillary purchase cancelled, passenger transport ticket and related ancillary purchase cancelled, etc.
    /// </summary>
    public IsoMax35Text? CreditReasonCode { get; init; } 
    /// <summary>
    /// Contains identification of the rail server procedure or the order in which the service was booked or a cancellation was completed. 
    /// </summary>
    public IsoMax35Text? ProcedureIdentification { get; init; } 
    /// <summary>
    /// Loyalty programme details. 
    /// </summary>
    public LoyaltyProgramme2? LoyaltyProgramme { get; init; } 
    /// <summary>
    /// Additional user-defined data pertaining to the transportation.
    /// </summary>
    public IsoMax350Text? AdditionalData { get; init; } 
    
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
        if (SequenceNumber is IsoMax35NumericText SequenceNumberValue)
        {
            writer.WriteStartElement(null, "SeqNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35NumericText(SequenceNumberValue)); // data type Max35NumericText System.String
            writer.WriteEndElement();
        }
        if (Ticket is Ticket2 TicketValue)
        {
            writer.WriteStartElement(null, "Tckt", xmlNamespace );
            TicketValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Document is DocumentReference1 DocumentValue)
        {
            writer.WriteStartElement(null, "Doc", xmlNamespace );
            DocumentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ProcedureReference is IsoMax35Text ProcedureReferenceValue)
        {
            writer.WriteStartElement(null, "PrcdrRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ProcedureReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (TransportType is TransportType1Code TransportTypeValue)
        {
            writer.WriteStartElement(null, "TrnsprtTp", xmlNamespace );
            writer.WriteValue(TransportTypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (OtherTransportType is IsoMax35Text OtherTransportTypeValue)
        {
            writer.WriteStartElement(null, "OthrTrnsprtTp", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(OtherTransportTypeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (CommodityCode is IsoMax4Text CommodityCodeValue)
        {
            writer.WriteStartElement(null, "CmmdtyCd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax4Text(CommodityCodeValue)); // data type Max4Text System.String
            writer.WriteEndElement();
        }
        if (Carrier is CarrierIdentification1 CarrierValue)
        {
            writer.WriteStartElement(null, "Crrier", xmlNamespace );
            CarrierValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RouteNumber is IsoMax35Text RouteNumberValue)
        {
            writer.WriteStartElement(null, "RouteNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(RouteNumberValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ServiceClass is IsoMax35Text ServiceClassValue)
        {
            writer.WriteStartElement(null, "SvcClss", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ServiceClassValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (Departure is DepartureOrArrival1 DepartureValue)
        {
            writer.WriteStartElement(null, "Dprture", xmlNamespace );
            DepartureValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Arrival is DepartureOrArrival1 ArrivalValue)
        {
            writer.WriteStartElement(null, "Arrvl", xmlNamespace );
            ArrivalValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Duration is IsoMax4NumericText DurationValue)
        {
            writer.WriteStartElement(null, "Drtn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax4NumericText(DurationValue)); // data type Max4NumericText System.String
            writer.WriteEndElement();
        }
        if (StopOverIndicator is IsoTrueFalseIndicator StopOverIndicatorValue)
        {
            writer.WriteStartElement(null, "StopOverInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(StopOverIndicatorValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (NonDirectRouteCode is IsoMax35Text NonDirectRouteCodeValue)
        {
            writer.WriteStartElement(null, "NonDrctRouteCd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(NonDirectRouteCodeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (FairBasisCode is IsoMax35Text FairBasisCodeValue)
        {
            writer.WriteStartElement(null, "FairBsisCd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(FairBasisCodeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (InsuranceIndicator is IsoTrueFalseIndicator InsuranceIndicatorValue)
        {
            writer.WriteStartElement(null, "InsrncInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(InsuranceIndicatorValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (TripLegAmount is AmountDetails2 TripLegAmountValue)
        {
            writer.WriteStartElement(null, "TripLegAmt", xmlNamespace );
            TripLegAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CreditReasonCode is IsoMax35Text CreditReasonCodeValue)
        {
            writer.WriteStartElement(null, "CdtRsnCd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CreditReasonCodeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ProcedureIdentification is IsoMax35Text ProcedureIdentificationValue)
        {
            writer.WriteStartElement(null, "PrcdrId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ProcedureIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (LoyaltyProgramme is LoyaltyProgramme2 LoyaltyProgrammeValue)
        {
            writer.WriteStartElement(null, "LltyPrgrmm", xmlNamespace );
            LoyaltyProgrammeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalData is IsoMax350Text AdditionalDataValue)
        {
            writer.WriteStartElement(null, "AddtlData", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(AdditionalDataValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
    }
    public static TripLeg2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

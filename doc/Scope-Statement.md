---
title : "Scope Statement"
description : "Statement of the scope of work done on this library."
summary : "Statement of the scope of work done on this library."
categories : ["ISO20022"]
generator : "RepositoryDocScopeStatementGenerator"
---
# Beneficial Strategies Implementation Scope

This document is to give you an idea of the scope of implementation of this library.
Considering that it employs some 17,666 constituent data structures in additon to it's 2,665 ISO messages, the library is rather vast.

## ISO 20022 Messages Implemented - 2,665

This library currently contains the implementation of 2665 messages.
They each fall into one of the 36 business categories enumerated below.

|Abbreviation|Business Area|Messages Implemented|
|------------|-------------|--------------------|
|acmt|Messages that support the management of account related activities, such as the opening and maintenance of an account.|123|
|admi|Generic messages, ie, system event notifications, generic rejections, etc.|10|
|auth|Messages that support the provision of miscellaneous financial information to authorities, such as Regulators, Police, Customs, Tax authorities, Enforcement authorities, Ministries, etc.|138|
|caaa|Messages that support any card payment related transactions and services between a card acceptor and a card transaction acquirer. It includes the authorisation, cancellation and capture of card transactions.|217|
|caad|Messages that support any card related administrative services between financial institutions and their agents.|17|
|caam|Messages that support card related terminal management services between an Automated Teller Machine (ATM) and an Acquirer.|24|
|cafc|Messages that support the reporting and advising of card payment transactions, including the collection of fees and processing of charge-backs.|4|
|cafm|Messages that support file management services in a card payment environment between financial institutions and/or their agents.|4|
|cafr|Messages that support card payment related fraud reporting and disposition services between financial institutions and their agents.|8|
|cain|Messages that support any card payment related transactions and services between a card transaction acquirer and a card issuer.|55|
|camt|Messages that support the reporting and advicing of the cash side of any financial transactions, including cash movements, transactions and balances, plus any exceptions and investigations related to cash transactions.|279|
|canm|Messages that support network management services in a card payment environment between financial institutions and/or their agents.|8|
|casp|Messages that support any card related transactions and services between a sale system and a Point of Interaction (POI) system.|82|
|casr|Messages that support card payment related settlement reporting services between financial institutions and their agents.|4|
|catm|Messages that support any card related terminal management services between a Terminal Management System (TMS) and a Point of Interaction (POI) system.|68|
|catp|Messages that support any card related Automated Teller Machine (ATM) transactions and services between an ATM equipment and an ATM acquirer. These services include cash withdrawals, kiosk functions and card account management transactions.|28|
|colr|Messages that support collateral management actions.|54|
|fxtr|Messages that support management processes for foreign exchange contracts, including reporting on trades and balances, plus any exceptions and investigations related to foreign exchange contracts.|33|
|head|Header that contains business information that is relevant before processing a message.|3|
|nvlp|Envelope Message Definitions describe technical messages that are used to bundle multiple message instances, typically to support processing or transport. Envelopes may contain different types of message instance and typically define additional data elements that apply to all contained message instances.|1|
|pacs|Messages that support the clearing and settlement processes for payment transactions between financial institutions.|78|
|pain|Messages that support the initiation of a payment from the ordering customer to a financial institution that services a cash account and reporting its status.|98|
|reda|Messages that support the communication of reference data related to financial instruments, parties, accounts, prices and other business information required to support financial activities.|63|
|remt|Messages that support communication between creditors and debtors regarding remittance details associated with payments.|7|
|secl|Messages that support the clearing process for securities, including management of post-trading, pre-settlement credit exposure, netting, margining, borrowing, conformance with market settlement rules.|10|
|seev|Messages that support asset servicing, including proxy voting, income and corporate actions.|344|
|seev|Messages that support asset servicing, including proxy voting, income and corporate actions.|344|
|semt|Messages that support post-settlement processes for securities (including reporting on securities movements, trades and balances), the processes required to protect beneficial owner's rights throughout settlement, plus any exceptions and investigations related to securities transactions.|181|
|semt|Messages that support post-settlement processes for securities (including reporting on securities movements, trades and balances), the processes required to protect beneficial owner's rights throughout settlement, plus any exceptions and investigations related to securities transactions.|181|
|sese|Messages that support the settlement process for securities and report its status and confirmation.|417|
|sese|Messages that support the settlement process for securities and report its status and confirmation.|417|
|setr|Messages that support trade and post-trade processes for securities, including order to buy or sell, trade execution, affirmation, confirmation, allocation and notification.|84|
|supl|Messages that add new components to existing message definitions in existing business areas. The messages are each a separate extension of an existing message and should always be linked to the supplementary data component in the (core) registered message.|109|
|tsin|Messages that support the request for a trade service, including any related application, instruction, request, acknowledgement or advice.|13|
|tsmt|Messages that support ancillary commercial trade services functions, including checking, matching and reporting, plus any exceptions and investigations related to trade services transactions.|69|
|tsrv|Messages that support the issuance of a trade services instrument, execution and/or settlement of a trade transaction, including any related reimbursement, acceptance, authorisation, claims, enquiries, invoicing, financing or other undertaking.|19|
## Supporting Architecture Counts

Each of the messages mentioned above requires supporting structures to fully describe the business content.
To facilitate this, the supporting implementation includes the following implementations.


| Type of supporting component                                         | Count                 |
|----------------------------------------------------------------------|-----------------------|
| Codesets supplying dropdown values defined from the specification    | 3,774 
| Codesets supplied externally that may change independently           | 86        
| Message components that are used to compose complex content          | 12,653   
| Business components used as building blocks across messages          | 783
| Simple types that are used for text, dates, etc, usually constrained | 358
| Types relating to external schema.                                   | 6
| Types relating to user-defined content.                              | 6
        

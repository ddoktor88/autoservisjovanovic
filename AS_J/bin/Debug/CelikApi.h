// CelikApi.h
//
#pragma once

#ifdef __cplusplus
extern "C" {
#endif

#ifndef WINAPI
#define WINAPI __stdcall
#endif

#ifndef EID_API
#define EID_API
#endif

//
// Constants
//

// Size of all UTF-8 fields in bytes

const int EID_MAX_DocRegNo = 9;
const int EID_MAX_IssuingDate = 10;
const int EID_MAX_ExpiryDate = 10;
const int EID_MAX_IssuingAuthority = 30;

const int EID_MAX_PersonalNumber = 13;
const int EID_MAX_Surname = 60;
const int EID_MAX_GivenName = 40;
const int EID_MAX_ParentGivenName = 25;
const int EID_MAX_Sex = 2;
const int EID_MAX_PlaceOfBirth = 25;
const int EID_MAX_StateOfBirth = 25;
const int EID_MAX_DateOfBirth = 10;
const int EID_MAX_CommunityOfBirth = 25;

const int EID_MAX_State = 3;
const int EID_MAX_Community = 25;
const int EID_MAX_Place = 25;
const int EID_MAX_Street = 36;
const int EID_MAX_HouseNumber = 5;
const int EID_MAX_HouseLetter = 2;
const int EID_MAX_Entrance = 3;
const int EID_MAX_Floor = 3;
const int EID_MAX_ApartmentNumber = 6;

const int EID_MAX_Portrait = 7700;

//
// Function return values
//

const int EID_OK                            =  0;
const int EID_E_GENERAL_ERROR               = -1;
const int EID_E_INVALID_PARAMETER           = -2;
const int EID_E_VERSION_NOT_SUPPORTED       = -3;
const int EID_E_NOT_INITIALIZED             = -4;
const int EID_E_UNABLE_TO_EXECUTE           = -5;
const int EID_E_READER_ERROR                = -6;
const int EID_E_CARD_MISSING                = -7;
const int EID_E_CARD_UNKNOWN                = -8;
const int EID_E_CARD_MISMATCH               = -9;
const int EID_E_UNABLE_TO_OPEN_SESSION      = -10;
const int EID_E_DATA_MISSING                = -11;
const int EID_E_CARD_SECFORMAT_CHECK_ERROR  = -12;
const int EID_E_SECFORMAT_CHECK_CERT_ERROR  = -13;

//
// Structures
//

// NOTE: char arrays DO NOT have zero char at the end

typedef struct tagEID_DOCUMENT_DATA
{
	char docRegNo[EID_MAX_DocRegNo];
	int docRegNoSize;
	char issuingDate[EID_MAX_IssuingDate];
	int issuingDateSize;
	char expiryDate[EID_MAX_ExpiryDate];
	int expiryDateSize;
	char issuingAuthority[EID_MAX_IssuingAuthority];
	int issuingAuthoritySize;
} EID_DOCUMENT_DATA, *PEID_DOCUMENT_DATA;

typedef struct tagEID_FIXED_PERSONAL_DATA
{
	char personalNumber[EID_MAX_PersonalNumber];
	int personalNumberSize;
	char surname[EID_MAX_Surname];
	int surnameSize;
	char givenName[EID_MAX_GivenName];
	int givenNameSize;
	char parentGivenName[EID_MAX_ParentGivenName];
	int parentGivenNameSize;
	char sex[EID_MAX_Sex];
	int sexSize;
	char placeOfBirth[EID_MAX_PlaceOfBirth];
	int placeOfBirthSize;
	char stateOfBirth[EID_MAX_StateOfBirth];
	int stateOfBirthSize;
	char dateOfBirth[EID_MAX_DateOfBirth];
	int dateOfBirthSize;
	char communityOfBirth[EID_MAX_CommunityOfBirth];
	int communityOfBirthSize;
} EID_FIXED_PERSONAL_DATA, *PEID_FIXED_PERSONAL_DATA;

typedef struct tagEID_VARIABLE_PERSONAL_DATA
{
	char state[EID_MAX_State];
	int stateSize;
	char community[EID_MAX_Community];
	int communitySize;
	char place[EID_MAX_Place];
	int placeSize;
	char street[EID_MAX_Street];
	int streetSize;
	char houseNumber[EID_MAX_HouseNumber];
	int houseNumberSize;
	char houseLetter[EID_MAX_HouseLetter];
	int houseLetterSize;
	char entrance[EID_MAX_Entrance];
	int entranceSize;
	char floor[EID_MAX_Floor];
	int floorSize;
	char apartmentNumber[EID_MAX_ApartmentNumber];
	int apartmentNumberSize;
} EID_VARIABLE_PERSONAL_DATA, *PEID_VARIABLE_PERSONAL_DATA;

typedef struct tagEID_PORTRAIT
{
	BYTE portrait[EID_MAX_Portrait];
	int portraitSize;
} EID_PORTRAIT, *PEID_PORTRAIT;


//
// Functions
//
EID_API int WINAPI EidStartup(int nApiVersion);
EID_API int WINAPI EidCleanup();

EID_API int WINAPI EidBeginRead(LPCSTR szReader);
EID_API int WINAPI EidEndRead();

EID_API int WINAPI EidReadDocumentData(PEID_DOCUMENT_DATA pData);
EID_API int WINAPI EidReadFixedPersonalData(PEID_FIXED_PERSONAL_DATA pData);
EID_API int WINAPI EidReadVariablePersonalData(PEID_VARIABLE_PERSONAL_DATA pData);
EID_API int WINAPI EidReadPortrait(PEID_PORTRAIT pData);

EID_API int WINAPI EidReadDocumentDataP(char *pchDocRegNo, int *pnDocRegNoSize,
										char *pchIssuingDate, int *pnIssuingDateSize,
										char *pchExpiryDate, int *pnExpiryDateSize,
										char *pchIssuingAuthority, int *pnIssuingAuthoritySize);

EID_API int WINAPI EidReadFixedPersonalDataP(char *pchPersonalNumber, int *pnPersonalNumberSize,
											 char *pchSurname, int *pnSurnameSize,
											 char *pchGivenName, int *pnGivenNameSize,
											 char *pchParentGivenName, int *pnParentGivenNameSize,
											 char *pchSex, int *pnSexSize,
											 char *pchPlaceOfBirth, int *pnPlaceOfBirthSize,
											 char *pchStateOfBirth, int *pnStateOfBirthSize,
											 char *pchDateOfBirth, int *pnDateOfBirthSize,
											 char *pchCommunityOfBirth, int *pnCommunityOfBirthSize);

EID_API int WINAPI EidReadVariablePersonalDataP(char *pchState, int *pnStateSize,
												char *pchCommunity, int *pnCommunitySize,
												char *pchPlace, int *pnPlaceSize,
												char *pchStreet, int *pnStreetSize,
												char *pchHouseNumber, int *pnHouseNumberSize,
												char *pchHouseLetter, int *pnHouseLetterSize,
												char *pchEntrance, int *pnEntranceSize,
												char *pchFloor, int *pnFloorSize,
												char *pchApartmentNumber, int *pnApartmentNumberSize);

EID_API int WINAPI EidReadPortraitP(BYTE *pchPortrait, int *pnPortraitSize);


#ifdef __cplusplus
};
#endif

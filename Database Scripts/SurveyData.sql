CREATE TABLE SurveyData (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    UserID NVARCHAR(100) NOT NULL,
    CreatedAt DATETIME NOT NULL, 
    Name NVARCHAR(500),
    DateOfBirth NVARCHAR(MAX),
    CivilStatus NVARCHAR(MAX),
    Gender NVARCHAR(200),
    Address NVARCHAR(MAX),

    SatisfiedOverall NVARCHAR(100) NOT NULL,
    RecommendFleetRewards NVARCHAR(100) NOT NULL,
    NavigateEasily NVARCHAR(100) NOT NULL,
    ClearInstructions NVARCHAR(100) NOT NULL,
    SatisfiedWithRewards NVARCHAR(100) NOT NULL, 
    QualityOfCustomerService NVARCHAR(100) NOT NULL, 
    SatisfiedRedeemingRewards NVARCHAR(100) NOT NULL,
    SatisfiedCustomerResponseTeam NVARCHAR(100) NOT NULL,
    InformedOfLatestRewards NVARCHAR(100) NOT NULL,
    RoomForImprovement NVARCHAR(100) NOT NULL  
);

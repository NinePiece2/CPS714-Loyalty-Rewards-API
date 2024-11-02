db.createCollection("FeedbackFormData", {
    validator: {
      $jsonSchema: {
        bsonType: "object",
        required: ["UserID", "Name"],
        properties: {
          ID: {
            bsonType: "int",
            description: "Auto-incrementing primary key"
          },
          UserID: {
            bsonType: "string",
            maxLength: 100,
            description: "User ID, required"
          },
          Name: {
            bsonType: "string",
            maxLength: 100,
            description: "Name, required"
          },
          Email: {
            bsonType: "string",
            maxLength: 255,
            description: "Email, required"
          },
          PhoneNumber: {
            bsonType: "string",
            maxLength: 15,
            description: "Phone number, required"
          },
          Topic: {
            bsonType: "string",
            maxLength: 50,
            description: "Topic, required"
          },
          Explanation: {
            bsonType: "string",
            description: "Explanation, required"
          },
          CreatedAt: {
            bsonType: "date",
            description: "Creation date, required"
          }
        }
      }
    }
});
  

db.counters.insertOne({
  _id: "feedbackId",
  seq: 0
});

// Function to increment and get the next ID
function getNextSequence(name) {
  const result = db.counters.findOneAndUpdate(
    { _id: name },
    { $inc: { seq: 1 } },
    { returnNewDocument: true }
  );
  return result.value.seq;
}

// Sample data entry
db.FeedbackFormData.insertOne({
  ID: getNextSequence("feedbackId"),
  UserID: "user123",
  Name: "John Doe",
  Email: "john@example.com",
  PhoneNumber: "123-456-7890",
  Topic: "Customer Service",
  Explanation: "Feedback explanation...",
  CreatedAt: new Date()
});

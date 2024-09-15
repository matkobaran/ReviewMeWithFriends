# Review with my friends
Project for reviewing restaurants with friends.

Publish for maccatalyst:
`dotnet build -f net8.0-maccatalyst
dotnet run -f net8.0-maccatalyst`

Publish for android:
`dotnet build -f net8.0-android
dotnet publish -f net8.0-android -c Release
adb install -r bin/Release/net8.0-android/com.companyname.reviewmewithfriends-Signed.apk`

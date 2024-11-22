
# react-native-hometown-grocery-exchanging

## Getting started

`$ npm install react-native-hometown-grocery-exchanging --save`

### Mostly automatic installation

`$ react-native link react-native-hometown-grocery-exchanging`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-hometown-grocery-exchanging` and add `RNHometownGroceryExchanging.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNHometownGroceryExchanging.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNHometownGroceryExchangingPackage;` to the imports at the top of the file
  - Add `new RNHometownGroceryExchangingPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-hometown-grocery-exchanging'
  	project(':react-native-hometown-grocery-exchanging').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-hometown-grocery-exchanging/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-hometown-grocery-exchanging')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNHometownGroceryExchanging.sln` in `node_modules/react-native-hometown-grocery-exchanging/windows/RNHometownGroceryExchanging.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Hometown.Grocery.Exchanging.RNHometownGroceryExchanging;` to the usings at the top of the file
  - Add `new RNHometownGroceryExchangingPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNHometownGroceryExchanging from 'react-native-hometown-grocery-exchanging';

// TODO: What to do with the module?
RNHometownGroceryExchanging;
```
  
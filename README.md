# ObjectPooling
 Object Pooling system for Unity C#

 The object pool pattern is a software creational design pattern that uses a set of initialized objects kept ready to use – a "pool" – rather than allocating and destroying them on demand.

In order to use this system:
 - Create an object, an instance, of the ObjectPooler class, which is going to be used as a Singleton.
 - In the ObjectPooler, create the structs that are going to contain the tags of the object you want to spawn and their respectives prefabs.
 - Now, using the ObjectPooler singleton, you may call the SpawnFromPool method in any script in order to spawn the desired object.

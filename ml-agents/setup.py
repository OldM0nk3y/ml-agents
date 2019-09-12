from setuptools import setup, find_namespace_packages
from os import path
from io import open

here = path.abspath(path.dirname(__file__))

# Get the long description from the README file
with open(path.join(here, "README.md"), encoding="utf-8") as f:
    long_description = f.read()

setup(
    name="mlagents",
    version="0.9.3",
    description="Unity Machine Learning Agents",
    long_description=long_description,
    long_description_content_type="text/markdown",
    url="https://github.com/Unity-Technologies/ml-agents",
    author="Unity Technologies",
    author_email="ML-Agents@unity3d.com",
    classifiers=[
        "Intended Audience :: Developers",
        "Topic :: Scientific/Engineering :: Artificial Intelligence",
        "License :: OSI Approved :: Apache Software License",
        "Programming Language :: Python :: 3.6",
    ],
    # find_namespace_packages will recurse through the directories and find all the packages
    packages=find_namespace_packages(
        exclude=["*.tests", "*.tests.*", "tests.*", "tests"]
    ),
    zip_safe=False,
    install_requires=[
        # Test-only dependencies should go in test_requirements.txt, not here.
        "mlagents_envs==0.9.3",
        "tensorflow>=1.7,<1.15",
        "Pillow>=4.2.1",
        "matplotlib",
        "numpy>=1.13.3,<=1.17.0",
        "jupyter",
        "docopt",
        "pyyaml",
        "protobuf>=3.6,<3.7",
        "grpcio>=1.11.0",
        "h5py>=2.9.0",
        'pypiwin32==223;platform_system=="Windows"',
    ],
    python_requires=">=3.6.1",
    entry_points={"console_scripts": ["mlagents-learn=mlagents.trainers.learn:main"]},
)
